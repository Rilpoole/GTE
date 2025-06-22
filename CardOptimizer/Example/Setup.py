import psycopg2
import random
from datetime import datetime, timedelta
from psycopg2.extras import execute_values

# Start
print("Start")

# Set constants
today = datetime(2025, 6, 23, 8, 0)

# Connect to PostgreSQL
conn = psycopg2.connect(
    dbname="CardOptimizer",
    user="postgres",
    password="password",
    host="localhost",
    port=5000
)
cur = conn.cursor()

# Reset tables
cur.execute('''
DELETE FROM public."Availability";
DELETE FROM public."Card";
DELETE FROM public."Employee";
DELETE FROM public."Item";
''')

# Add items
items = ["Stock Net", "Custom Net", "Stock Pads", "Custom Pads", "Bazooka", "UV-TOP", "Slider Attachment"]
for item in items:
    cur.execute('INSERT INTO public."Item" ("Name") VALUES (%s)', (item,))

# Add employees
employees = ["Micah", "Aubree", "Melania", "David", "Daniel", "Cesar", "Emil"]
for employee in employees:
    cur.execute('INSERT INTO public."Employee" ("Name") VALUES (%s)', (employee,))

# Example start date for availability
cur.execute('SELECT "EmployeeId", "Name" FROM public."Employee"')
employee_map = {name: emp_id for emp_id, name in cur.fetchall()}
start_date = datetime(2025, 6, 22, 8, 0)
end_date = start_date + timedelta(days=180)

current_date = start_date
while current_date <= end_date:
    # weekday() returns 0 for Monday ... 6 for Sunday
    if current_date.weekday() < 5:  # 0-4 means Monday to Friday
        for emp_name, emp_id in employee_map.items():
            from_str = current_date.strftime("%Y-%m-%dT%H:%M")
            to_str = (current_date + timedelta(hours=9)).strftime("%Y-%m-%dT%H:%M")
            cur.execute('''
                INSERT INTO public."Availability" ("Employee", "From", "To")
                VALUES (%s, %s, %s)
            ''', (emp_id, from_str, to_str))
    current_date += timedelta(days=1)


# Get employee and item IDs
cur.execute('SELECT "EmployeeId", "Name" FROM public."Employee"')
employee_map = {name: emp_id for emp_id, name in cur.fetchall()}
aubree_id = employee_map["Aubree"]
melania_id = employee_map["Melania"]
david_id = employee_map["David"]
daniel_id = employee_map["Daniel"]
cesar_id = employee_map["Cesar"]
emil_id = employee_map["Emil"]

cur.execute('SELECT "ItemId", "Name" FROM public."Item"')
item_map = {name: item_id for item_id, name in cur.fetchall()}

# Create orders and insert
order_data = []
for i in range(100000, 100100):
    order_name = f"Invoice {i}"
    nominal_date = today + timedelta(days=random.randint(-14, 0))
    due_date = nominal_date + timedelta(days=random.randint(0, 60))
    priority = random.randint(25, 100)
    order_data.append((order_name, nominal_date, 'Order', priority, due_date, david_id))

execute_values(cur, '''
    INSERT INTO public."Card" 
    ("Name", "NominalDate", "CardType", "Priority", "DueDate", "Employee")
    VALUES %s
    RETURNING "CardId", "Name"
''', order_data)

# Map order names to inserted CardIds
order_name_to_id = {name: card_id for card_id, name in cur.fetchall()}

# Create productions based on orders
production_data = []
for order_name, order_id in order_name_to_id.items():
    item_name = random.choice(items)
    item_id = item_map[item_name]
    qty = random.randint(1, 10)
    duration = random.randint(15, 120)
    fatigue = random.randint(1, 100)
    nominal_date = today + timedelta(days=random.randint(-14, 0))
    production_name = f"Produce ({qty}) {item_name} for {order_name}"

    # Assign employees based on item type
    if item_name == "Stock Net":
        employeeId = melania_id
    elif item_name == "Custom Net":
        employeeId = aubree_id
    elif item_name == "Stock Pads":
        employeeId = daniel_id
    elif item_name == "Custom Pads":
        employeeId = aubree_id
    elif item_name == "Bazooka":
        employeeId = emil_id
    elif item_name == "UV-TOP":
        employeeId = emil_id
    elif item_name == "Slider Attachment":
        employeeId = emil_id
    else:
        employeeId = david_id  # default

    production_data.append((
        production_name,
        nominal_date,
        duration,
        order_id,
        'Production',
        employeeId,
        fatigue,
        item_id,
        qty
    ))

# Insert production cards
execute_values(cur, '''
    INSERT INTO public."Card" 
    ("Name", "NominalDate", "Duration", "Parent", "CardType", "Employee", "Fatigue", "Item", "Qty")
    VALUES %s
    RETURNING "CardId", "Name"
''', production_data)

# Map production names to CardIds
production_rows = cur.fetchall()
production_name_to_id = {name: card_id for card_id, name in production_rows}

# Create requisition cards linked to productions
requisition_data = []
materials_map = {
    "Stock Net": "Vinyl",
    "Custom Net": "Ink",
    "Stock Pads": "Vinyl",
    "Custom Pads": "Ink",
    "Bazooka": "Poles",
    "UV-TOP": "Bolts",
    "Slider Attachment": "Winches"
}

for prod_name, prod_id in production_name_to_id.items():
    # Extract item name from production name string
    try:
        # 'Produce (qty) ItemName for Invoice ...'
        parts = prod_name.split(' for ')[0]  # e.g. 'Produce (3) Stock Net'
        item_part = parts.split(') ')[1]      # e.g. 'Stock Net'
    except IndexError:
        item_part = ""

    material = materials_map.get(item_part, "Misc")
    qty = random.randint(1, 20)
    req_name = f"Requisition for {qty} {material} ({prod_name})"
    nominal_date = today + timedelta(days=random.randint(-14, 0))
    duration = random.randint(5, 30)

    requisition_data.append((
        req_name,
        nominal_date,
        duration,
        prod_id,
        'Requisition',
        cesar_id,
        qty
    ))

# Insert requisition cards
execute_values(cur, '''
    INSERT INTO public."Card"
    ("Name", "NominalDate", "Duration", "Parent", "CardType", "Employee", "Qty")
    VALUES %s
''', requisition_data)

# Commit and close
conn.commit()
cur.close()
conn.close()

print("End")

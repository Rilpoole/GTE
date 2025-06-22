from datetime import datetime,timedelta

for i in range(100):
    start = datetime(2025,1,1,8,0)
    end = datetime(2025,1,1,17,0)
    delta = timedelta(seconds=24*60*60*i)
    print(f"Start: {start+delta} End: {end+delta}")
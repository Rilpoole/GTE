using Core.Objects;

namespace Core.Documents
{
    ///
    public class OperationsSheetItem
    {
        public OperationsSheetItem(int seq, Labor labor, Machine machine, SetupSheet setupSheet, int qty, bool machineRequired)
        {
            Seq = seq;
            Labor = labor ?? throw new ArgumentNullException(nameof(labor));
            Machine = machine ?? throw new ArgumentNullException(nameof(machine));
            SetupSheet = setupSheet ?? throw new ArgumentNullException(nameof(setupSheet));
            Qty = qty;
            MachineRequired = machineRequired;
        }

        public int Seq {  get; private set; }
        public Labor Labor { get; private set; }
        public Machine Machine { get; private set; }
        public SetupSheet SetupSheet { get; private set; }
        public int Qty { get; private set; }
        public bool MachineRequired { get; private set; } = false; 
    }
}

namespace Notepad
{
    public class Tools : ITools
    {
        public string[] Temp { get; set; }
        public int Index { get; set; }
        public int CurrntPosition { get; set; }

        public Tools()
        {
            Temp = new string[200];
            Index = 0;
            CurrntPosition = 0;
        }

        public void Insert(string str)
        {
            Temp[Index] = str;
            CurrntPosition = Index;
            Index++;
        }

        public string Redo()
        {
            if (CurrntPosition < Index)
                return Temp[++CurrntPosition];
            return null;
        }

        public string Undo()
        {
            if (CurrntPosition > 0)
                return Temp[--CurrntPosition];
            return null;
        }
    }
}


namespace Multiple_Heritage.Devices
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            System.Console.WriteLine("ComboDevice processing " + document);
        }

        public string Scan()
        {
            return "ComboDevice scan result";
        }

        public void Print(string document)
        {
            System.Console.WriteLine("ComboDevice Print " + document);
        }
    }
}

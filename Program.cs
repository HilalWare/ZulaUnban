using Microsoft.Win32;
using System;



namespace UnBanZula
{
    class Program
    {
        static void Main(string[] args)
        {

            RegistryKey key  = Registry.LocalMachine.OpenSubKey(@"HARDWARE\DESCRIPTION\System\CentralProcessor\0", true);


            key.DeleteValue("ProcessorNameString");




            key.SetValue("ProcessorNameString", "Amd 9 12212x");






        }
    }

}

using System;
using System.IO;
using System.Linq;
using System.Net.Mime;


namespace Wulkanizacja
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.Clear();
				string patch = @"C:\Lista.txt";

				int[] options = new[]
				{
1, 2, 3
};

				Console.WriteLine("#####################################");
				Console.WriteLine("#                                   #");
				Console.WriteLine("#          Wybierz nr:              #");
				Console.WriteLine("#                                   #");
				Console.WriteLine("# 1. Dodaj nowego klienta           #");
				Console.WriteLine("# 2. Wyświetla liste klientów       #");
				Console.WriteLine("# 3. Zamknij                        #");
				Console.WriteLine("#                                   #");
				Console.WriteLine("#####################################");

				string option = Console.ReadLine();
				if (!String.IsNullOrWhiteSpace(option))
				{
					int nr = int.Parse(option);
					if (options.Contains(nr))
					{
						Console.Clear();
						switch (nr)
						{
							case 1:
								Console.WriteLine("Podaj dane dotyczące klienta i informacje dotyczące opon:");
								var note = Console.ReadLine();
								using (StreamWriter sw = !File.Exists(patch) ? File.CreateText(patch) : File.AppendText(patch))
								{
									if (note != string.Empty)
									{
										sw.WriteLine(note);
										sw.WriteLine(DateTime.Now);
										sw.WriteLine("-------------------------------------");
									}
								}
								continue;

							case 2:
								if (File.Exists(patch))
								{
									using (StreamReader sw = File.OpenText(patch))
									{
										string s = String.Empty;
										while ((s = sw.ReadLine()) != null)
										{
											Console.WriteLine(s);
										}
										Console.ReadLine();
									}
								}
								else
								{
									Console.WriteLine("Brak klientów");
									Console.ReadLine();
								}
								continue;
							case 3:
								Environment.Exit(0);
								break;
						}
					}
					else
					{
						Console.Clear();
						Console.WriteLine("Podłes niepoprawny rozmiar opon");
						Console.ReadLine();
						continue;
					}
				}
				break;
			}
		}

	}
    public interface IDeviceWrapper
    {
        void WrapperMethod();
    }

    public class ConcreteDevice
    {
        

        internal void Method()
        {
            throw new NotImplementedException();
        }
    }

    public class ConcreteDeviceWrapper : IDeviceWrapper
    {
        private ConcreteDevice m_concreteDevice;

        public ConcreteDeviceWrapper()
        {
            m_concreteDevice = new ConcreteDevice();
        }

        public void WrapperMethod()
        {
            if (m_concreteDevice != null)
            {
                m_concreteDevice.Method();
            }
        }
    }
}
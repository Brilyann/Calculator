class Calculator
{
	static void Main (string[] args)
	{
		int a = 10;
		int b = 6;
		
		Consoloe.WriteLine("Hasil Penambahan: {0} + {1} ={2}",a,b,Penambahan(a, b));
		Consoloe.WriteLine("Hasil Pengurangan: {0} - {1} ={2}",a,b,Penngurangan(a, b));
		
		Consoloe.WriteLine("\n Tekan sembarang key untuk keluar");
		Consoloe.ReadKey();
	}
	static int Penambahan (int a, int b)
	{
		return a + b;
	}
	static int Pengurangan(int a, int b)
	{
		return a - b;
	}
	
}
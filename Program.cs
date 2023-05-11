using Project2.Helpers;
using System.Text.RegularExpressions;

try
{
	int age=int.Parse(Console.ReadLine());
	if(age<16)
	{
		throw new AgecheckException(Helper.ExceptionMessage["AgecheckException"]);
	}

}
catch (AgecheckException ex)
{

    Console.WriteLine(ex.Message);
}
catch (InvalidCastException ex)
{
	throw new Exception("Herifi yanlis girdiniz");
}
catch (FormatException ex)
{
	throw new Exception("Format sehvdir");
}
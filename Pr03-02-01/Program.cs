﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Pr03_02_01
{
  class Program
  {
    static void Main(string[] args)
    {
      StreamReader sr = new StreamReader("boot.ini");
      StreamWriter sw = new StreamWriter("boot-utf7.txt", false, Encoding.UTF7);
      sw.WriteLine(sr.ReadToEnd());
      sw.Close();
      sr.Close();
    }
  }
}

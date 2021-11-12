using System;
using ChadwickSimulation;

Building cir;
cir = new Building("Center for Innovation and Research", 70);
Console.WriteLine(cir.name);
Console.WriteLine(cir.capacity);
string cirInfo = cir.GetInfo();
Console.WriteLine(cirInfo);

Building roessler;
roessler = new Building("Roessler Hall", 200);
Console.WriteLine(roessler.GetInfo());

Building christensen;
christensen = new Building("Christensen Hall", 107);
Console.WriteLine(christensen.GetInfo());
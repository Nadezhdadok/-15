using Задача_15;

GeomProgression geom = new GeomProgression();
geom.setStart(10);
geom.setStep(2);
Console.WriteLine(geom.getNext());
Console.WriteLine(geom.getNext());
Console.WriteLine(geom.getNext());
geom.reset();
Console.WriteLine(geom.getNext());
Console.WriteLine(geom.getNext());

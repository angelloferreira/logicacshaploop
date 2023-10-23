for (int i = 0; i < 11; i++)
{
    Console.WriteLine(i);
}

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

string[] nomes = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < nomes.Length; i++)
    if (nomes[i] == "David") nomes[i] = "Sammy";

foreach (var name in nomes) Console.WriteLine(name);


string[] nanes = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < nanes.Length; i++)
{
    if (nanes[i] == "David") nanes[i] = "Sammy";
}

foreach (var name in nanes)
{
    Console.WriteLine(name);
}
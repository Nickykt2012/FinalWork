string[] source = new string[] { "hello", "2", "world", ":-)" };       
string[] target = new string[0];
    
for (int i = 0; i < source.Length; i++)
{
    if (source[i].Length <= 3)
    {
    Array.Resize(ref target, target.Length + 1);
    target[target.Length - 1] = source[i];
    }
}         
for (int i = 0; i < target.Length; i++)  
    {           
    Console.WriteLine(target[i]);
    }
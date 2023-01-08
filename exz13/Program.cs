int[] array = {1, 15, 18, 44 ,57, 29, 37, 39};

int n = array.Length;
int find = 44;

int index = 0;

while (index < n)
{
  if(array[index] == find)
  break;
  {
    Console.WriteLine(index);
  }
  index++;
}

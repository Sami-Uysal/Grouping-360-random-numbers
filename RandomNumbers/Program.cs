// See https://aka.ms/new-console-template for more information

int groupnum;
int groupelenum;

Console.WriteLine("How many would you like to create a group?");
groupnum = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[360];
groupelenum = 360/ groupnum;

int[] group = new int[groupelenum];

Random random = new Random();

int a = 0;
double toplam = 0;
int number = random.Next(1, 1000);
bool status  = true;



for (int i = 0; i < numbers.Length ; i++)
{
    do
    {
        status  = true;
        for (int j = 0; j < i; j++)
        {
            if (numbers[j] == number)
            {
                status  = false;
                number = random.Next(1, 1000);
            }
        }
    } while (status  != true);
    numbers[i] = number;
}
Array.Sort(numbers);

for (int i = 0; i < groupnum; i++)
{
    for (int e = 0; e < groupelenum; e++)
    {
        group[e] = numbers[a];
        a++;
    }

    for (int d = 0; d < groupelenum; d++)
    {
        toplam += group[d];
    }

    double average = toplam / group.Length;
    string ad = "Group " + (i + 1).ToString();
    Console.WriteLine(ad + " : " + string.Join(",", group));
    Console.WriteLine(ad + " Average  : " + average);
}
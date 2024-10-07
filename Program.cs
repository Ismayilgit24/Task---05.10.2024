 //Task - 1
//int[] numbers = { 21, 33, 49, 15, 6, 91 };
//int i;
//int j;
//bool result = false;
//for (i = 0; i < numbers.Length; i++)
//{
//	result = false;
//	for (j = 2; j < numbers[i]; j++)
//		if (numbers[i] % j == 0)
//		{
//			result = true;
//		}

//	if (result)
//	{
//		Console.WriteLine(numbers[i]);
//	}
//}
 
 

 //Task - 2
//int[] numbers1 = { 1, 3, 5, 7, 8 };
//int[] numbers2 = { 2, 4, 1, 4, 3 };
//Console.WriteLine("Beraber olan ededler : ");
//int i, j = 0;
//for (i = 0; i < numbers1.Length; i++)
//{
//	for (j = 0; j < numbers2.Length; j++)
//	{
//		if (numbers1[i] == numbers2[j])
//		{
//			Console.WriteLine(numbers1[i]);
//		}
//	}
//} 
 

 
 //Task - 3
//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//int minIndex = 0;
//int maxIndex = 0;

//for (int i=0; i<numbers.Length; i++)
//{
//	if (numbers[i] > numbers[maxIndex])
//	{
//		maxIndex = i;
//	}
//	if (numbers[i] < numbers[minIndex])
//	{
//		minIndex = i;
//	}
//}
//Console.WriteLine(minIndex);
//Console.WriteLine(maxIndex); 
 

 
 //Task - 4
//Console.WriteLine("Ededi daxil edin : ");
//int number = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
//for (; number > 0; number/=10)
//{
//	sum += number % 10;
//}
//Console.WriteLine("Mertebeleri cemi : " + sum);



 //Task - 5
 //int[] numbers = { 2, 5, 3, 6, 4, 8, 10, 1, 9 };
//int i, j = 0;
//bool result = true;
//for (i = 1; i <= 10; i++)
//{
//	result = false;

//	for (j = 0; j < numbers.Length; j++)
//	{
//		if (numbers[j] == i)
//		{
//			result = true;
//			break;
//		}
//	}

//	if (!result)
//	{
//		Console.WriteLine("Eksik olan rəqəm: " + i);
//		break;
//	}
//} 






















// 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
#region yontem 1 math ile

//int yasEnBuyuk(int y1, int y2, int y3)
//{
//	return Math.Max(Math.Max(y1, y2), y3);
//}
#endregion

#region Yontem 2  
/*
int yasEnBuyuk(int y1, int y2, int y3)
{
	if (y1 > y2)
	{
		if (y1 > y3)
			return y1; 
		else  
			return y3;
	} 
	else
	{
		if (y2 < y3)
			return y2; 
		else
			return y3;
	}
}
*/


#endregion

#region yontem 3
/*
int yasEnBuyuk(int y1, int y2, int y3)
{
   if (y1 > y2 && y1 > y3)
       return y1; 
   else if (y2 > y3)
       return y2;
   else
       return y3;
}
*/
#endregion

#region yontem 4
int yasEnBuyuk(int y1, int y2, int y3)
{
	int enBuyuk = y1; 
	if (y2 > enBuyuk) enBuyuk = y2;
	if (y3 > enBuyuk) enBuyuk = y3;
	return enBuyuk;	
}
#endregion
Console.WriteLine(yasEnBuyuk(65, 18, 44)); 
 
Console.ReadKey();
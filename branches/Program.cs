int sum = 0;
for (int x = 1; x<20; x++){
    if (x%3 == 0){
        sum=sum+x;
        Console.WriteLine($"current summary = {sum}");
    }
}
Console.WriteLine($"Summa ravna = {sum}");

int[] array = new int[6] { 22,27,16,2,18,6};



 1)


 dizinin ilk elemanı diğer elemanlarla kıyaslanır en küçük olanla dizinin ilk elemanının yeri değiştirilir

array = { 2,27,16,22,18,6};

  2 elemanı zaten sıralama yapılarak geldiği için işleme tekrar sokulmaz 27 elemanlarla kıyaslanır ve 6 ile yeri değiştirilir

array ={ 2,6,16,22,18, 27};

  16 geri kalan elemanlarla kıyaslanır en küçük o olduğu için yer değişikliği olmaz

array ={ 2,6,16,22,18, 27};

 22 diğerleriyle kıyaslanır

array ={ 2,6,16,18,22, 27};

 22 tekrar kıyaslandığında zaten 27 den küçük olduğundan yer değişikliği olmaz

array ={ 2,6,16,18,22, 27};




 2)  Big O notation nu ---> O(n^2) dir

 average case : 
 worst case :  n + (n-1) + (n-2) +....  --> 1den n e kadar olan sayı toplamı formülünden (n(n+1))/2 den en büyük katsayı alınacağından O(n^2) olur
 best case : 

  4) 18 dizinin ortasında olduğundan average case kapsamına girer



[7,3,5,8,2,9,4,15,6]

1. adım -->  [2, 3, 5, 8, 7, 9, 4, 15, 6]

2. adım -->  [2, 3, 5, 8, 7, 9, 4, 15, 6]

3. adım -->  [2, 3, 4, 8, 7, 9, 5, 15, 6]

4. adım -->  [2, 3, 4, 5, 7, 9, 8, 15, 6]









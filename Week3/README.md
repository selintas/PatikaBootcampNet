## C# Fundamentals Project
Proje haftasına hoş geldiniz! Bu projede sizlerden 3 aşamalı bir uygulama geliştirmeniz isteniyor. Uygulamayı çalıştıran kullanıcıya program seçeneklerini konsol üzerinden sunarak bir tanesini seçmesini isteyiniz.

Hangi programı çalıştırmak istersiniz - 3 farklı seçenek :

1 - Rastgele Sayı Bulma Oyunu

2 - Hesap Makinesi

3 - Ortalama Hesaplama

Rastgele Sayı Bulma Oyunu

Bilgisayar bir rastgele sayı belirlesin (örneğin 1 ile 100 arasında).

Kullanıcıdan bu sayıyı tahmin etmesini isteyin.

Kullanıcı her tahmininde, bilgisayarın seçtiği sayıya yakınlığını kontrol edin ve ipucu verin (daha yüksek veya daha düşük).

Kullanıcının 5 canı olsun (5 tahmin hakkı). Her tahmin sonrası kalan canını gösterin.

Kullanıcı doğru tahminde bulunursa oyunu bitirin ve tebrik edin.

Eğer 5 tahmin hakkı dolarsa, doğru sayıyı gösterin ve oyunu bitirin.

Hesap Makinesi

Kullanıcıya ilk sayıyı girmesini isteyin.

Kullanıcıya ikinci sayıyı girmesini isteyin.

Kullanıcıya yapmak istediği işlemi seçmesini isteyin:

Toplama için +

Çıkarma için -

Çarpma için *

Bölme için /

Kullanıcının seçimine göre uygun işlemi gerçekleştirip sonucu ekrana yazdırın. Eğer bölme işlemi seçildiyse, sıfıra bölme hatası durumunu kontrol edin.

Programı yazarken dikkat etmeniz gereken noktalar:

Kullanıcı girdilerini doğru bir şekilde almak için Console.ReadLine() ve Convert.ToInt32() gibi metodları kullanın.

İşlem seçiminde if-else veya switch-case yapısını kullanarak uygun işlemi gerçekleştirin.

Bölme işlemi yapılırken sıfıra bölme hatasını kontrol edin ve kullanıcıya uygun bir mesaj gösterin.

Ortalama Hesaplama

Kullanıcıdan birinci ders notunu girmesini isteyin.

Kullanıcıdan ikinci ders notunu girmesini isteyin.

Kullanıcıdan üçüncü ders notunu girmesini isteyin.

Girdiği notların ortalamasını hesaplayın ve ekrana yazdırın.

Notların geçerli olup olmadığını kontrol edin (0-100 aralığında olmalıdır). Geçersiz bir not girildiğinde kullanıcıya hata mesajı verin ve programı sonlandırın.

Ortalama notun harf karşılığını göstermek için aşağıdaki harf notu tablosunu kullanın:

90-100: AA
85-89:  BA
80-84:  BB
75-79:  CB
70-74:  CC
65-69:  DC
60-64:  DD
55-59:  FD
0-54:   FF
Programı yazarken dikkat etmeniz gereken noktalar:

Kullanıcı girdilerini doğru bir şekilde almak için Console.ReadLine() ve Convert.ToDouble() gibi metodları kullanın.

Notların geçerliliğini kontrol etmek için if yapısını kullanın.

Ortalama hesaplamasını doğru bir şekilde yapmak için double türünde bir değişken kullanın.

Harf notu tablosunu kullanarak kullanıcının aldığı ortalamaya karşılık gelen harf notunu belirleyin ve ekrana yazdırın.

Başarılar dilerim!

___

## C# Fundamentals Project
Welcome to project week! In this project, you are required to develop a 3-phase application. Present the user with program options via the console and ask them to choose one.

Which program would you like to run - 3 different options:

1 - Random Number Guessing Game

2 - Calculator

3 - Average Grade Calculation

Random Number Guessing Game
The computer selects a random number (e.g., between 1 and 100).

Ask the user to guess this number.

After each guess, check how close the guess is to the selected number and give a hint (higher or lower).

The user has 5 lives (5 attempts). Show the remaining lives after each guess.

If the user guesses correctly, end the game and congratulate them.

If all 5 attempts are used, show the correct number and end the game.

Calculator
Ask the user to enter the first number.

Ask the user to enter the second number.

Ask the user to choose the operation they wish to perform:

For addition, enter +
For subtraction, enter -
For multiplication, enter *
For division, enter /
Perform the appropriate operation based on the user's choice and display the result. If division is selected, handle the division-by-zero error.

Key points to consider:

Use Console.ReadLine() and Convert.ToInt32() to correctly capture user input.
Use an if-else or switch-case structure to handle the operation selection.
For division, check for division by zero and display an appropriate message to the user.
Average Grade Calculation
Ask the user to enter their first subject grade.

Ask the user to enter their second subject grade.

Ask the user to enter their third subject grade.

Calculate the average of the entered grades and display it on the screen.

Check if the grades are valid (they must be in the range 0-100). If an invalid grade is entered, show an error message and terminate the program.

Use the following letter grade table to display the corresponding letter grade:

90-100: AA
85-89: BA
80-84: BB
75-79: CB
70-74: CC
65-69: DC
60-64: DD
55-59: FD
0-54: FF
Key points to consider:

Use Console.ReadLine() and Convert.ToDouble() to correctly capture user input.
Use an if statement to validate the entered grades.
Use a double type variable to correctly calculate the average.
Use the letter grade table to determine the letter grade corresponding to the user's average and display it.
Good luck!
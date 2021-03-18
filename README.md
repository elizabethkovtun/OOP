# OOP

Лабораторні роботи з ООП


Half1- лабораторні за перший семестр(2020/2021)

  
  Лабораторна робота 1
   
      Завдання 1(Варіант 3)
        
Кожен рядок матриці A на першій і останній позиції містить індекси відповідно початку і кінця діапазону елементів рядка, які необхідно переписати у відповідний рядок матриці B. Створити матрицю B з необхідною кількістю стовпчиків у кожному рядку та переписати до неї вказані елементи з матриці A. Відсортувати кожен рядок матриці A за зростанням.
      
      Завдання 2
      
Створити клас TTriangle для подання трикутника. Поля (protected) повинні містити дані про довжини сторін (для кожної з трьох сторін своє поле). Потрібно реалізувати:
* конструктор, який заповнює всі три довжини (перевіряючи можливість існування такого трикутника);
* отримання (get) довжини сторони (три окремі методи, для кожної сторони свій);
* задання (set) довжини сторони (три окремі методи, для кожної сторони свій; перевіряти можливість існування такого трикутника, де ця одна сторона змінена, а решта дві лишаються, які були);
* отримання периметру трикутника
* отримання площі трикутника (через формулу Герона)

  
  Лабораторна робота 2
  
  
  Завдання 1(варіант 6)
  
Реалізувати клас, що представляє трикутник (трикутник задається координатами вершин) і містить опис індексатора для доступу до сторін трикутника( a – перша сторона, b – друга сторона, c – третя сторона). Передбачити методи введення / виведення, знаходження периметру та площі.


  Завдання 2(варіант 6)
  
1. Описати клас, який містять вказані поля і методи.
Клас “коло” – TCircle
Поля  для зберігання радіуса;
Методи  конструктор без параметрів, конструктор з параметрами, конструктор копіювання;

override public string ToString();
введення/виведення даних;
визначення площі круга (обмеженого колом);
визначення довжини кола;
порівняння з іншим колом;
перевантаження операторів + (додавання радіусів), – (віднімання радіусів), * (множення радіуса на число; забезпечити, щоб домноження могло відбуватися хоч як «число*коло», хоч як «коло*число»).

2. Створити клас-нащадок TCylinder (циліндр) на основі класу TCircle. Додати поле висоти
циліндру, метод знаходження об’єму циліндра та перевизначити відповідні методи.

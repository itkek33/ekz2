import math
import string
import random
import datetime
1
Fam = input("Введите вашу фаимилию: ")
Mark = input("Введите оценку: ")
print(f"Поздравляю, {Fam}! У Вас автоматом {Mark} за экзамен.")


2
a = int(input("Введите сколько чисел: "))
mas = []
sum  = 0.0
for i in range(a):
    mas.append(int(input(f"Введите число номер {i+1}:")))
    sum+=float(mas[i])
print(f"{mas} среднее знач. {round(sum/a,2)}  округленние {round(sum/a) } в меньшую {int(sum/a) }")


3
NumCheak = False
UPCheak = False
LOwCheak = False
SpecSymvolCheak = False
Specsimvol = string.punctuation
while True:
    password = input("Введите пароль: ")
    
    for i in range(len(password)):
        if password[i].isdigit():
            NumCheak = True
        if password[i].isupper():
            UPCheak = True    
        if password[i].islower():
            LOwCheak = True 
        if password[i] in Specsimvol :
            SpecSymvolCheak = True
    if len(password) >= 20 or len(password) <= 8:
        print("Пароль должен быть от 8 до 20 символов")
    elif NumCheak == False:
        print("В пароле должна быть хотя бы одна цифра")
    elif UPCheak == False:
        print("В пароле должна быть хотя бы одна заглавная буква")
    elif LOwCheak == False:
        print("В пароле должна быть хотя бы одна строчная буква")    
    elif SpecSymvolCheak == False:
        print("В пароле должен быть хотя бы один спецсимвол")   
    else:
        print("Пароль подходит")
        break

4

Marks = 0

for i in range(3):
    a = random.randint(1,24)
    b = random.randint(1,24)
    c = random.randint(1,24)
    print(f"{a} {b} {c}")
    ansv = int(input("Ведите число: "))
    
    if ansv == a or ansv == b or ansv == c:
        Marks = Marks + 1
    
    print(f"{a} {b} {c} \nВаше число: {ansv} \nКоличество ваших балов: {Marks}\n ")
    
if Marks >= 2:
    print("Вы выиграли")
else:
    print("Вы проиграли")

5
dataizg = datetime.date.today() + datetime.timedelta(days=random.randint(-7,0))
godnodo = dataizg+ datetime.timedelta(days=random.randint(1,7)) 
price = random.randint(10,100)

print(f"Дата изготовление {dataizg}  годно до {godnodo} сегодня {datetime.date.today()} цена {price}")

if dataizg == datetime.date.today():
    pass
elif godnodo > datetime.date.today():
    price*=0.8
else:
    price = 0
    
print(f"Цена после перерасчёта {round(price,2)}")

6
person_dict = { 'person_id': [41, 84, 72], 
                'person_name': ['Keanu Reeves', 'Jim Carrey', 'Negr']} 
travel_log = { 'travel_id': [101, 102, 105], 
                'person_id': [41, 72, 41], 
                'country': [ 'USA', 'Japan', 'China']}

name = input("Кто вам интересен: ")
dopCheak = 0 

for i in range(len(person_dict.get('person_name'))):
    if name == person_dict.get('person_name')[i]:
        cheack = 0  
        for j in range (len(travel_log.get('person_id'))):
            if travel_log.get('person_id')[j] == person_dict.get('person_id')[i]:
                dopCheak = j
                cheack +=1
                
                  
if cheack == 0:
    print(None)
elif cheack == 1:
    print(travel_log.get('country')[dopCheak])
elif cheack == 2:
    print("Several")

7


Estimation  = []
date  = []

randomMaks = ["б", "п","н", 2, 3, 4, 5]

for i in range(11):
    Estimation.append(randomMaks[random.randint(0,6)])
    date.append(datetime.date.today() + datetime.timedelta(days=i))
        
for i in range(len(Estimation)):
    print(f"{Estimation[i]}||{date[i]}")
NUmBol = 0
for i in range(len(Estimation)):
    if Estimation[i] == "б" and date[i].month == datetime.date.today().month:
        print(date[i])
        NUmBol +=1
print(f"Количество пропусков по болезни за месяц {NUmBol} ")

    
    
8


randomMaks = ["б", "п","н", 2, 3, 4, 5]

class Student:
    fio = ""
    group = ""
    yerPost = ""
    
    Estimation = []
    date = []
    def __str__(self):
        return f"студент {self.fio} группа {self.group} год поступления {self.yerPost}"
        
    def __init__(self,fio,group,yerPost ):
        self.fio = fio
        self.group = group
        self.yerPost = yerPost
        

    def GenMarks(self):
        for i in range(11):
            self.Estimation.append(randomMaks[random.randint(0,6)])
            self.date.append(datetime.date.today() + datetime.timedelta(days=i))
    def PrintMarks(self):
        for i in range(len(Student.Estimation)):
            print(f"студент {self.name} оценки{Student.Estimation[i]}||{Student.date[i]}")
            
aboba1 = Student("негр1", "Ис-21", "18-06-2023")
print(aboba1)
aboba1.GenMarks()
aboba1.PrintMarks()

aboba2 = Student("негр2", "Ис-21", "18-06-2023")
print(aboba2)
aboba2.GenMarks()
aboba2.PrintMarks()

aboba3 = Student("негр3", "Ис-21", "18-06-2023")
print(aboba3)
aboba3.GenMarks()
aboba3.PrintMarks()


class Group:
    nameGroup = ""
    students = []
    def __init__(self,nameGroup):
        self.nameGroup = nameGroup
      
    def Print(self):
        for stud in self.students:
            print(f"студент группы {self.nameGroup} {stud}")
        
    
    def append(self, student):
        self.students.append(student)
        
abobaGroup = Group("Ис-21")
abobaGroup.append(aboba1)
abobaGroup.append(aboba2)
abobaGroup.Print()
        

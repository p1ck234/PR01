# PR01
Практическое занятие №1
Тема: Проверка входных данных на корректность Описание задачи. 

Вашей задачей является разработка подсистемы для сохранения базы 
сотрудников в некоторый файл employee.txt. 
Первым шагом необходимо создать окно создания сотрудника 
(приложение WPF), в котором должны быть следующие поля:
• Идентификатор* 
• Фамилия* 
• Имя* 
• Отчество 
• Паспорт (серия и номер)* 
• Мобильный телефон 
• Email* 

На данном этапе можно не сильно обращать внимание на дизайн окна. 
Он будет доработан в дальнейшем. 
Должна присутствовать проверка на правильный формат вводимого 
email адреса, мобильного телефона, серии и номера паспорта, идентификатора, 
а также фамилии, имени и отчества. 

Email 
Email адрес должен состоять из двух частей, разделенных символом 
«@». Левая часть – логин - указывает имя почтового ящика и может 
начинаться только с буквы латинского алфавита. Также логин может 
содержать цифры и символ нижнего подчеркивания (соответственно, если 
такие символы не являются первыми). Правая часть – домен – это URL 
почтового сервиса, на котором зарегистрирован email. Будем считать, что у 
нашей фирмы есть свой домен – firma.ru и все сотрудники имеют 
соответствующий email адрес. 

Мобильный телефон 
Пользователь может ввести номер телефона в одном из следующих
форматов: 
1. 81234567890 – первая цифра – «8», всего 11 символов. 
2. +71234567890 – сначала идет «+7» и в этом случае номер имеет 12 
символов. 
Другие форматы записи чисел не принимаются. 

Серия и номер паспорта 
Серия и номер паспорта записываются только при помощи числовых 
значений. Первые четыре из них – это серия документа, а оставшиеся шесть –
его номер. 
Идентификатор 
Идентификатор у двух разных сотрудников не может повторяться (если 
есть сотрудник с идентификатором 5, то система не должна позволять 
добавить еще одного сотрудника с таким же идентификатором). 

ФИО 
ФИО сотрудников может содержать только символы кириллицы. ФИО 
пишется с заглавной буквы. 


В итоге все данные должны быть записаны в файл employee.txt в 
следующей последовательности: Идентификатор, Фамилия, Имя, Отчество, 
Паспорт (серия и номер), Мобильный телефон, Email. Между данными 
сущностями в текстовом файле должен стоять символ табуляции. Информация 
об одном сотруднике должна храниться в одной строке

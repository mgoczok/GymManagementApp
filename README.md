# 💪 KFIT – System Zarządzania Siłownią (Desktop App)

## 👥 Autorzy:
- Mateusz Goczok  
- Sebastian Pająk  

---

## 🧾 Opis projektu

**KFIT** to aplikacja desktopowa wspierająca zarządzanie siłownią oraz użytkownikami trenującymi siłowo.  
Umożliwia pracownikom siłowni m.in. rejestrację użytkowników, przypisywanie ich do grup treningowych, tworzenie planów ćwiczeń oraz przeglądanie statusów płatności.  
Aplikacja została stworzona w technologii **Windows Forms (C#)** i współpracuje z bazą danych **MySQL**.

---

## 🖥️ Technologia

- .NET (Windows Forms)  
- Język: C#  
- Baza danych: MySQL  
- Biblioteka: `MySql.Data` (MySqlConnector)

---

## 🔧 Funkcje

-  Logowanie administratora (`LoginForm`)
-  Zarządzanie użytkownikami:
   Dodawanie (`AddUserForm`)
   Edycja (`EditUserForm`)
   Usuwanie i przegląd (`UserManagementForm`)
-  Zarządzanie grupami treningowymi (`GroupManagementForm`)
   Tworzenie grup (`TrainingGroup`)
   Przypisywanie użytkowników
-  Zarządzanie planami treningowymi (`TrainingManagementForm`)
   Typ planu: `CardioTraining`, `StrengthTraining`, `GeneralTraining`
   Nazwa, opis, lista ćwiczeń, czas trwania
-  Przegląd statusów płatności (`PaymentsForm`)
-  Przejrzyste widoki danych (`DataGridView`)
-  Bezpośrednia komunikacja z bazą MySQL (`DatabaseHelper.cs`)


---

## 📌 Przykładowy przebieg działania

1. Administrator loguje się przez `LoginForm`
2. W `MainPanelForm` wybiera operację: zarządzanie użytkownikami, grupami, planami lub płatnościami
3. Dodaje użytkownika i przypisuje go do grupy
4. Tworzy plan treningowy (np. `CardioTraining`) przypisany do grupy
5. Może przeglądać status płatności użytkowników

---

## 📎 Linki

- [Repozytorium GitHub](https://github.com/mgoczok/GymManagementApp)  
- Dokumentacja projektu KFIT [Dokumentacja](https://docs.google.com/document/d/1MdDYTozUvKZkoMoNhbUP1GgWAnoxanYu/edit?usp=sharing&ouid=115259876342809122980&rtpof=true&sd=true)


---

## Proces instalacji

1. Pobierz projekt  
   Sklonuj repozytorium lub pobierz jako ZIP:  
   [https://github.com/mgoczok/GymManagementApp](https://github.com/mgoczok/GymManagementApp)
   
2. Otwórz projekt w Visual Studio

3. Zainstaluj zależności NuGet
   Otwórz *Package Manager Console* i wpisz:  
   Install-Package MySql.Data

4. Skonfiguruj połączenie z bazą danych
W pliku `DatabaseHelper.cs` podmień dane do logowania do MySQL
  - Utwórz bazę danych MySQL
  - Uruchom lokalny serwer MySQL (np. XAMPP).

5. Utwórz bazę o nazwie ,np. gymdb
  - Zaimportuj plik .sql dostępny tutaj:
[https://github.com/mgoczok/baza](https://github.com/mgoczok/baza)

6. Uruchom projekt
- Wybierz projekt jako startowy w Visual Studio (GymManagementApp)

Kliknij F5 lub przycisk „Start”

--- 
## 📈 Plany na przyszłość

- Kalendarz i harmonogram zajęć
- Moduł trenerów personalnych
- Statystyki aktywności i postępów użytkowników
- Synchronizacja z aplikacją webową

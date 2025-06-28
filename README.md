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

- 🔐 Logowanie administratora (`LoginForm`)
- 👥 Zarządzanie użytkownikami:
  - Dodawanie (`AddUserForm`)
  - Edycja (`EditUserForm`)
  - Usuwanie i przegląd (`UserManagementForm`)
- 🏋️‍♂️ Zarządzanie grupami treningowymi (`GroupManagementForm`)
  - Tworzenie grup (`TrainingGroup`)
  - Przypisywanie użytkowników
- 🗓️ Zarządzanie planami treningowymi (`TrainingManagementForm`)
  - Typ planu: `CardioTraining`, `StrengthTraining`, `GeneralTraining`
  - Nazwa, opis, lista ćwiczeń, czas trwania
- 💳 Przegląd statusów płatności (`PaymentsForm`)
- 📊 Przejrzyste widoki danych (`DataGridView`)
- 🔄 Bezpośrednia komunikacja z bazą MySQL (`DatabaseHelper.cs`)


---

## 📌 Przykładowy przebieg działania

1. Administrator loguje się przez `LoginForm`
2. W `MainPanelForm` wybiera operację: zarządzanie użytkownikami, grupami, planami lub płatnościami
3. Dodaje użytkownika i przypisuje go do grupy
4. Tworzy plan treningowy (np. `CardioTraining`) przypisany do grupy
5. Może przeglądać status płatności użytkowników

---

## 📎 Linki

- 🔗 [Repozytorium GitHub](https://github.com/mgoczok/GymManagementApp)  
- 📁 [Struktura projektu (Google Drive)](https://drive.google.com/drive/folders/11qJBdhl79cRjp44qzcRHsMAu46lUl03p?usp=drive_link)  

---

## 📌 Status projektu

✅ Wersja desktopowa funkcjonalna  
🛠️ Trwają prace nad rozszerzeniami (np. przypisywanie ćwiczeń, optymalizacja interfejsu, rozszerzenie modeli treningowych)

---



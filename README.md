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

- 🔐 Logowanie administratora
- 👥 Zarządzanie użytkownikami:
  - Dodawanie, edycja (osobny formularz), usuwanie
- 🏋️‍♂️ Zarządzanie grupami treningowymi (`TrainingGroup`)
  - Tworzenie grup, przypisywanie użytkowników
- 🗓️ Zarządzanie planami treningowymi
  - Nazwa, opis, lista ćwiczeń, czas trwania
- 💳 Przegląd statusów płatności
- 📊 Przejrzyste widoki danych (`DataGridView`)
- 🔄 Bezpośrednia komunikacja z bazą MySQL

---

## 🗃️ Struktura danych

### Główne tabele w bazie:
- `Users`
- `TrainingGroups`
- `Trainings`
- `Payments`

### Przykładowe komponenty aplikacji:
- `LoginForm` – logowanie  
- `MainForm` – główny panel  
- `AddUserForm` – dodawanie użytkownika  
- `EditUserForm` – edycja danych  
- `TrainingGroupForm` – zarządzanie grupami  
- `TrainingPlanForm` – edycja planów treningowych

---

## 📌 Przykładowy przebieg działania

1. Administrator loguje się przez `LoginForm`
2. W `MainForm` wybiera operacje: zarządzanie użytkownikami, grupami lub planami
3. Użytkownik jest dodawany i przypisywany do grupy
4. Tworzony jest plan treningowy przypisany do grupy
5. Administrator może sprawdzić status płatności każdego użytkownika

---

## 📎 Linki

- 🔗 [Repozytorium GitHub](https://github.com/mgoczok/GymManagementApp)  
- 📁 [Struktura projektu (Google Drive)]()  
- 

---

## 📌 Status projektu

✅ Wersja desktopowa funkcjonalna  
🛠️ Trwają prace nad rozszerzeniami (np. przypisywanie ćwiczeń, optymalizacja interfejsu)

---



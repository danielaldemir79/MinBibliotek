# MinBibliotek

MinBibliotek är ett konsolbaserat bibliotekssystem skrivet i C# (.NET 8) där tre olika användartyper (Admin, Librarian, Borrower) kan logga in och utföra olika uppgifter beroende på roll. Programmet är tänkt att simulera grundläggande funktioner i ett bibliotek, såsom att lägga till, ta bort, låna och visa böcker.

---

## Funktioner

### Inloggning
- Vid start möts användaren av en inloggningsmeny.
- Inloggning sker med användarnamn och lösenord.
- Tre fördefinierade användare finns:
  - **Admin**: användarnamn `admin`, lösenord `admin123`
  - **Librarian**: användarnamn `librarian`, lösenord `librarian123`
  - **Borrower**: användarnamn `borrower`, lösenord `borrower123`

### Roller och deras menyer

#### Admin
- **Lägg till bok**: Lägg till en ny bok i biblioteket.
- **Ta bort bok**: Ta bort en bok med hjälp av ISBN.
- **Visa alla böcker**: Lista alla böcker och deras status.
- **Avsluta**: Logga ut och återgå till startsidan.

#### Librarian
- **Lägg till bok**: Lägg till en ny bok i biblioteket.
- **Visa alla böcker**: Lista alla böcker och deras status.
- **Avsluta**: Logga ut och återgå till startsidan.

#### Borrower
- **Låna en bok**: Låna en bok med hjälp av ISBN (om den är tillgänglig).
- **Lämna tillbaka en bok**: Lämna tillbaka en bok med hjälp av ISBN.
- **Visa alla böcker**: Lista alla böcker och deras status.
- **Avsluta**: Logga ut och återgå till startsidan.

---

## Så använder du programmet

1. **Starta programmet**  
   Kör projektet i Visual Studio eller via terminalen.

2. **Logga in**  
   Ange användarnamn och lösenord enligt ovan.

3. **Navigera i menyn**  
   Välj alternativ genom att skriva in siffran för önskat val och tryck Enter.

4. **Utför åtgärder**  
   Följ instruktionerna i konsolen för att lägga till, ta bort, låna eller visa böcker.

5. **Logga ut**  
   Välj "Avsluta" i menyn för att logga ut och återgå till startsidan.

---

## Tekniska detaljer

- Programmet är skrivet i C# 12 och riktar sig mot .NET 8.
- Användarroller ärver från en gemensam abstrakt klass `User`.
- Böcker hanteras i en statisk lista i klassen `Book`.
- Inloggning och rollhantering sker via klassen `LoggaIn`.
- Validering av inmatning sker via hjälpfunktioner i klassen `Validering`.

---# MinBibliotek
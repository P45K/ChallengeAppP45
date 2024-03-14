//  TYPY REFERENCYJNY I WARTOŚCIOWE

//  TYP REFERENCYJNY                TYP WARTOŚCIOWY
/* 
    var emp = new                   int number = 12;
    Employee("Edziu");
    
    - w zmiennej "emp" przechowujemy obiekt(referencje) do obiektu "Employee"
    - w typie wartościowym (typ prosty) przechowujemy wartość np "12"
    - w przypadku typów referencyjnych przechowujemy miejsce w pamięci(adres), gdzie nasz program wie, że tam ma przechowywać obiekt typu "Employee"
    - obydwa typy są przechowywane w uporządkowanej strukturze w pamięci, która nazywa się "STOSEM"
    - obiekt "Employee" przechowywany jest w "STERCIE" 
    - najprostrzym sposobem na ropzpoznanie z jakim typem mamy do czynienia jest przejście do implementacji i tam jeżeli nie ma słówka "class", to znaczy, że mamy do czynienia z typem wartościowym
    - STRING jest typem referencyjnym ale zachowuje się jak typ wartościowy - jest hybrydą (immutable - niezmienny)
 */


using ChallengeAppP45;

    User user1 = new User("Władziu", "567890", "Władysław");
    User user2 = new User("Władek", "765432", "Władysław");
    User user3 = new User("Tadziu", "67890", "Tadeusz", 1985);
    User user4 = new User("Edziu", "09876", "Edward", 1980);
    User user5 = new User("Radziu", "99988", "Radosław", 1979);

    user1.AddPositivePoints(5);
    user1.AddPositivePoints(3);
    user1.AddPositivePoints(7);
    user1.AddNegativePoints(-1);

    user2.AddPositivePoints(5);
    user2.AddPositivePoints(3);
    user2.AddPositivePoints(7);
    user2.AddNegativePoints(-1);

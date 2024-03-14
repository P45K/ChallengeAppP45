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
 */


using ChallengeAppP45;

    User user1 = new User("Przemek", "12345");
    User user2 = new User("Gabriel", "54321");
    User user3 = new User("Julia", "67890");
    User user4 = new User("Wioleta", "09876");

    user1.AddPositivePoints(5);
    user1.AddPositivePoints(3);
    user1.AddPositivePoints(7);
    user1.AddNegativePoints(-1);

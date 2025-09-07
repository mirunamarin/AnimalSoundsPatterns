Console app (C#) care demonstrează **două design patterns** de pe [refactoring.guru](https://refactoring.guru/design-patterns):
- **Strategy** – fiecare animal are propriul comportament (sunetul).
- **Factory Method** – creatorii concreți instanțiază animalul potrivit după nume.
Comenzi utile: `list` (arată animalele disponibile), `exit` (închide aplicația).

## Patterns folosite

### Strategy
- **Interfață:** `IAnimal` (`Type`, `Sound`)
- **Implementări:** `Dog`, `Cat`, `Cow`, `Duck`
- **Beneficiu:** comportamentul e izolat pe clasă; extensibil – adaugi o clasă nouă fără să atingi restul codului.

### Factory Method
- **Creator abstract:** `AnimalCreator` (proprietate `Type`, metodă abstractă `Create()`)
- **Creatori concreți:** `DogCreator`, `CatCreator`, `CowCreator`, `DuckCreator`
- **Beneficiu:** decizia de creare este delegată subclaselor; codul de selecție în `Program` rămâne curat.

##  Unit tests

Proiectul include **2 teste** care dovedesc cele 2 design patterns:

1. **Strategy** – verifică faptul că `Dog` are comportamentul corect (`Type="Dog"`, `Sound="woof"`).
2. **Factory Method** – verifică faptul că `CatCreator.Create()` întoarce un `Cat` cu `Sound="meow"`.

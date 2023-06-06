# Kolokwium 2
## Przygotowanie do kolokwium:
### Pobranie gałęzi oraz przygotowanie projektów
1) Proszę pobrać gałąź kolokwium w formie pliku zip. A następnie wypakować jego zawartość.
  <img src="Img/download_zip.png" width=350 height=300></img>
2) Proszę uruchomić Visual Studio, a następnie w wypakowanym wcześniej folderze stworzyć solucję o nazwie `Kolokwium` oraz trzy poniższe projekty:
    - `Kolokwium.WpfApp` typu WPF Application,
    - `Kolokwium.DAL` typu WPF Class library,
    - `Kolokwium.Model` typu WPF Class library.
3) Proszę ustanowić zależność poniższe zależności:
    - Proszę ustanowić zależność (dependency) pomiędzy `Kolokwium.WpfApp` a `Kolokwium.Model`. Projekt  `Kolokwium.WpfApp` powinien posiadać zależność od `Kolokwium.Model` ( `Kolokwium.WpfApp` => `Kolokwium.Model`).
    - Proszę ustanowić zależność (dependency) pomiędzy `Kolokwium.WpfApp` a `Kolokwium.DAL`. Projekt  `Kolokwium.WpfApp` powinien posiadać zależność od `Kolokwium.DAL` ( `Kolokwium.WpfApp` => `Kolokwium.DAL`).
    - Proszę ustanowić zależność (dependency) pomiędzy `Kolokwium.DAL` a `Kolokwium.Model`. Projekt  `Kolokwium.DAL` powinien posiadać zależność od `Kolokwium.Model` ( `Kolokwium.DAL` => `Kolokwium.Model`).  
4) Proszę skompilować całą solucję klikając PPM w `Solution Explorerze` na Solucji `Kolokwium` a następnie wybierając `Build Solution`.

    ![Alt text](Img/compile_solution.png?raw=true)

5) Proszę zainstalować poniższe pakiety (z NuGet) w projekcie `Kolokwium.DAL`:
    - Microsoft.EntityFrameworkCore
    - Microsoft.EntityFrameworkCore.Design
    - Microsoft.EntityFrameworkCore.SqlServer
    - Microsoft.EntityFrameworkCore.Tools

6) Proszę zainstalować poniższe pakiety (z NuGet) w projekcie `Kolokwium.WpfApp`:
    - Microsoft.EntityFrameworkCore.Design
3) Proszę otworzyć plik `Kolokwium.Web -> appsettings.json` a następnie podmienić wartość `Database` connection stringa podając swoje imię i nazwisko (bez znaków diakrytycznych) zamiast `Imie_Nazwisko`. Dzięki temu w momencie zastosowania pierwszej migracji utworzy się nowa baza danych zaczynającą się Państwa imieniem i nazwiskiem.
    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=Imie_Nazwisko_Kolokwium2_AppDb;Trusted_Connection=True;MultipleActiveResultSets=true"
      },
      "Logging": {
        "LogLevel": {
          "Default": "Information",
          "Microsoft": "Warning",
          "Microsoft.Hosting.Lifetime": "Information"
        }
      },
      "AllowedHosts": "*"
    }
    ```  
5) Proszę stworzyć wszystkie elementy modelu w projekcie `Kolokwium.Model`, natomiast wszystkie elementy dostępu do danych tj. `ApplicationDbContext` w projekcie `Kolokwium.DAL`. 
```diff
- UWAGA: W przypadku umieszczenia elementów kolokwium w innym miejscu niż powyższej określone, spowoduje znaczne obniżenie oceny lub uzyskanie oceny niedostatecznej. 
```
### Proszę przejść do wykonywania zadań

```diff
- Życzę Państwu powodzenia podczas kolokwium! :)
```
### Umieszenie rozwiązania w archiwum
1)  Po zakończeniu czasu przeznaczonego na kolokwium, proszę klinąć PPM w `Solution Explorerze` na Solucji `Kolokwium` a następnie wybrać `Clean Solution`.
    ![Alt text](Img/clean_solution.png?raw=true)
2) Następnie proszę uruchomić `Terminal (View -> Terminal)`.
3) Znajdując sie w folderze `Kolokwium` proszę wykonać w nim poniższe polecenia.
    ```powershell
   Remove-Item Kolokwium.WpfApp/bin -Recurse -Force
   Remove-Item Kolokwium.WpfApp/obj -Recurse -Force
   Remove-Item Kolokwium.DAL/bin -Recurse -Force
   Remove-Item Kolokwium.DAL/obj -Recurse -Force
   Remove-Item Kolokwium.Model/bin -Recurse -Force
   Remove-Item Kolokwium.Model/obj -Recurse -Force
    
    ```
  Proszę się upewnić że foldery `bin` i `obj` zostały usunięte ze wszystkich projektów.
    
    <img src="Img/del_folders.png" width=600 height=300></img>
 
 4) Następnie proszę spakować całą solucję do pliku `Rozwiazanie_Kolokwium.zip`. Proces ten można wykonać przy pomocy programu `7-zip` lub przy pomocy poniższego polecenia:
    ```
    cd ..
    tar caf Rozwiazanie_Kolokwium.zip --exclude=./Rozwiazanie_Kolokwium.zip Kolokwium
    cd Kolokwium 

    ```
5)  Proszę przejść pod adres [Archiver](http://ik2a.kik.pcz.czest.pl/archiver/TestArchive/Index)
6)  Następnie proszę wybrać Państwa test i kilknąć przycisk `Link`

    ![Alt text](Img/ArchiverUpload1.png?raw=true)
    
7)  Proszę wypełnić formularz podając swoje dane, wskazać plik `Rozwiazanie_Kolokwium.zip`, a następnie nacisnąc przycisk `Upload`

    ![Alt text](Img/ArchiverUpload2.png?raw=true)
    
 

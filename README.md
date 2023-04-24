# Kolokwium
## Przygotowanie do kolokwium:
### Pobranie gałęzi oraz przygotowanie projektów
1) Proszę pobrać gałąź kolokwium w formie pliku zip. A następnie wypakować jego zawartość.
  <img src="Img/download_zip.png" width=350 height=300></img>
2) Proszę uruchomić Visual Studio, a następnie w wypakowanym wcześniej folderze stworzyć solucję o nazwie `Kolokwium` oraz dwa poniższe projekty:
    - `Kolokwium.App` typu Console Application,
    - `Kolokwium.BLL` typu Class library.
3) Proszę ustanowić zależność (dependency) pomiędzy `Kolokwium.App` a `Kolokwium.BLL`. Projekt  `Kolokwium.App` powinien posiadać zależność od `Kolokwium.BLL` ( `Kolokwium.App` => `Kolokwium.BLL`). 
4) Proszę skompilować całą solucję klikając PPM w `Solution Explorerze` na Solucji `Kolokwium` a następnie wybierając `Build Solution`.

    ![Alt text](Img/compile_solution.png?raw=true)

5) Proszę stworzyć wszystkie elementy kolokwium (klasy, interfejsy, etc.) w projekcie `Kolokwium.BLL`. 
```diff
- UWAGA: W przypadku umieszczenia elementów kolokwium w innym miejscu, spowoduje to znaczne obniżenie oceny lub uzyskanie oceny niedostatecznej. 
```
  Jedynym elementem który należy umieścić w projekcie `Kolokwium.App` jest kod testujący. Znajduje się on pod poniższym adresem:
  [http://ik2a.kik.pcz.czest.pl/po/{code}.pdf](http://ik2a.kik.pcz.czest.pl/po/code.pdf)
  Proszę zastąpić `{code}` wartością kodu podaną przez prowadzącego.

### Uruchomienie dokumentacji
W trakcie trwania kolokwium mogą Państwo korzystać z dostarczonej dokumentacji Microsoft Learn. 
[https://learn.microsoft.com](https://learn.microsoft.com)

### Proszę przejść do wykonywania zadań

```diff
- Życzę Państwu powodzenia podczas kolokwium! :)
```
### Umieszenie rozwiązania w archiwum
1)  Po zakończeniu czasu przeznaczonego na kolokwium, proszę klinąć PPM w `Solution Explorerze` na Solucji `Kolokwium` a następnie wybrać `Clean Solution`.
    ![Alt text](Img/clean_solution.png?raw=true)
2)  Następnie proszę spakować całą solucję do pliku `Imie_Nazwisko_Kolokwium.zip`, podając swoje `Imie` i `Nazwisko` jako początek nazwy pliku. Np. `Jan_Kowalski_Kolokwium.zip` Proszę dodać WSZYSTKIE pliki należące do solucji.
3)  Proszę przejść pod adres [Archiver](http://ik2a.kik.pcz.czest.pl/archiver/TestArchive/Index)
4)  Następnie proszę wybrać Państwa test i kilknąć przycisk `Link`

    ![Alt text](Img/ArchiverUpload1.png?raw=true)
    
5)  Proszę wypełnić formularz podając swoje dane, wskazać plik `Imie_Nazwisko_Kolokwium.zip`, a następnie nacisnąc przycisk `Upload`

    ![Alt text](Img/ArchiverUpload2.png?raw=true)
    
 

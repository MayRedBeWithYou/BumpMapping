# Zadanie 2 - Dominik Sellin

Aplikacja pozwala na rysowanie wielokątów i generowanie losowych wielokątów wypukłych przesuwających się od prawej, do lewej. W czasie animacji obliczana jest część wspólna wielokątów narysowanych i generowanych i jest ona wypełniana na jeden z kilku sposobów. Część wspólna wyznaczana jest metodą Sutherlanda-Hodgmana. Wypełnienie korzysta z algorytmu skan-linii z sortowaniem kubełkowym krawędzi.


## Wielokąty i animacja

Dostępne jest kilka paneli z opcjami. Pierwszy odpowiada za tworzenie i edycję własnych (statycznych) wielokątów.
Po zaznaczeniu opcji "Animuj" generowane będą w równych odstępach czasowych losowe wielokąty wypukłe (kod w Algorithms.cs w metodzie GenerateRandomPolygon). Przy każdym przesunięciu następuje wyznaczenie części wspólnej owych wielokątów (kod w Algorithms.cs w metodzie GetIntersectedPolygon) i wypełnienie jej w odpowiedni sposób (metoda FillIntersection w Form1.cs, linia ~803).
Odznaczenie "Animuj" spowoduje zatrzymanie ruchu wielokątów, ale ich nie usunie. Od tego jest przycisk poniżej.
## Wypełnienie

Części wspólne wielokątów można wypełnić na 3 sposoby:
1) Interpolacją kolorów (losowych) z wierzchołków generowanego wielokąta.
2) Teksturą wczytaną z pliku .jpg, .bmp lub .png.
3) Teksturą z dołączoną mapą normalną.

## Oświetlenie
Przy wybraniu opcji nr 3 można dobrać wartości odpowiednich współczynników dla modelu Lamberta oraz wysokości, na której znajduje się nasze światło. Niżej znajduje się opcja, dzięki której można wybrać kolor światła. Domyślnie jest to kolor biały.

Domyślnie światło określone jest stałym wektorem [0,0,1], jednak przy zaznaczeniu opcji "Włącz własną lampę" wektor do światła będzie wyliczany dla każdego punktu wypełnienia. Miejsce, w którym znajduje się żarówka, oznaczone jest żółtym kółkiem.

Aby umieścić światło w innym miejscu, wystarczy nacisnąć prawy przycisk myszy.

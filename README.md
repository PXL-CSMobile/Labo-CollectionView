# Labo - CollectionView
## Deel 1
- Voeg een CollectionView toe aan de MainPage van de applicatie.
- Geef de CollectionView een naam: ```charactersCollectionView```.
- Gebruik de ```GetData()``` functie in de MainPage.xaml.cs klasse om een generieke lijst van characters op te halen.
- Gebruik de ```ItemsSource``` property van de CollectionView om de lijst van characters te gebruiken als databron.
- Bekijk het resultaat in de applicatie.

## Deel 2
- Gebruik nu de ```DataRepository.GetAllCharacters()``` functie (in plaats van de *GetData()*) om een generieke lijst van characters op te halen.
- Bekijk het resultaat in de applicatie.

## Deel 3
- Overschrijf de ```ToString()``` functie van de *MiniFig* klasse om de weergave in de CollectionView aan te passen. Retourneer de *Name* en *Race* eigenschap van elk object.
- Bekijk het resultaat in de applicatie.

## Deel 4
- Voeg een *ItemTemplate* met *DataTemplate* toe aan de CollectionView:
```
<CollectionView x:Name="charactersCollectionView">
    <CollectionView.ItemTemplate>
        <DataTemplate>
                    
        </DataTemplate>
    </CollectionView.ItemTemplate>
</CollectionView>
```
- Voeg een GridLayout toe aan de DataTemplate met 2 rijen en 2 kolommen.
- Voeg een Image toe aan de GridLayout. Deze image...
    - staat in de eerste kolom met een rowspan van 2
    - heeft een breedte en een hoogte van 60
    - heeft een aspect property met waarde *AspectFill*
- Gebruik nu databinding om de *ImageUrl* eigenschap van de *MiniFig* klasse te binden aan de *Source* eigenschap van de *Image* klasse:
```
Source="{Binding ImageUrl}"
```
- Voeg een Label toe aan de GridLayout. Dit label...
	- staat in de tweede kolom en eerste rij
	- heeft een tekstkleur van *Black*
	- heeft een fontsize van *Medium*
    - heeft een fontweight van *Bold*
- Gebruik nu databinding om de *Name* eigenschap van de *MiniFig* klasse te binden aan de *Text* eigenschap van de *Label* klasse
- Voeg een Label toe aan de GridLayout. Dit label...
	- staat in de tweede kolom en tweede rij
	- heeft een tekstkleur van *Black*
	- heeft een fontsize van *Small*
    - bevat cursieve tekst
    - wordt verticaal onderaan uitgelijnd
- Gebruik nu databinding om de *Race* eigenschap van de *MiniFig* klasse te binden aan de *Text* eigenschap van de *Label* klasse
- Voeg nu rond de GridLayout een rand toe door gebruik te maken van het *\<border\>* element
    - Stroke="Black" 
    - StrokeThickness="1" 
    - Margin="2" 
    - Padding="2"

<img src="media/minifigs.png" alt="minifigs" height="400">


## Bronnen
- [Minifigures](https://www.brickowl.com/catalog/lego-minifigures/the-lord-of-the-rings)
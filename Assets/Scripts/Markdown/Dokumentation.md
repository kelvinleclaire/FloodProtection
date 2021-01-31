# Technische Dokumentation
von Kenzo Rohde und Kelvin Leclaire


## Logik
Das Spiel startet in der MainScene mit dem StartCanvas. Dieser wird beim Dr�cken des Startknopfes deaktivert und aktiviert den Welcome Canvas.
Man kann nun bereits das Kamerabild sehen und bekommt durch einen Text und eine Audiodatei das Setting des Spiels erkl�rt.
Wenn man nun auf Start dr�ckt kann man seine Stadt platzieren und der Timer startet.
In dem [WaterScript](../Water/WaterScript.cs) f�ngt das Wasser mit jedem Timertick an in y-Richtung zu skalieren. Sobald ein Wasser-Cube auf einen Sandsack
trifft stopt dies.
Die Sands�cke lassen sich durch den [PlacementSelectionController](../Raycast/PlacementSelectionController.cs) platzieren. Hier wird der Raycast daf�r verwendet,
dass der erste Touch, sollte er einen Sandsack treffen, diesen ausw�hlt und der zweite Touch, falls ein Sandsack ausgew�hlt ist, diesen platziert.
Hierbei kann der Spieler nicht jeden Sandsack beliebig platzieren, sondern nur in den daf�r vorgesehnen Dropzones.
Dieses Script erm�glicht es auch, dass durch ein Tippen auf die Telefonzelle der OrderCanvas aufgerufen wird. 
Hier kommt das [OrderScript](../OrderCanvas/OrderScript.cs) ins Spiel. Per Knopfdruck werden zwei neue Sands�cke bestellt und in der Ladezone platziert.
Der Spieler ist auf 8 Sands�cke pro Runde limitiert.
Wenn der Timer aus dem WaterScript abgelaufen ist, wird einer der drei EndCanvases sichtbar. �ber 3 Checkpoints, welche in dem [DetectResult Script](../EndScreen/DetectResult.cs) �berpr�fen, bis wo das Wasser
vordringen konnte, wird entweder der Victory Screen, der Haltwin Screen, oder der Lose Screen aufgerufen. Hier wird erneut eine Audiodatei abgespielt
und der Spieler ist in der Lage das Spiel neuzustarten. Daf�r resettet das [RestartGame Script](../EndScreen/RestartGame.cs) alle globalen Variablen und l�d die Mainscene neu.

#### UML Diagramm
![Hier ist ein Bild](UML.png)

#### Ordnerstruktur
- Assets
     * Audio
     * Canvas
          - Materials
     * Imports
         - BrokenVector
         - FlamingSands
         - HousePack
         - LowpolyStreetPack
         - phone
         - POLYGON city pack
         - Stylize Water Texture
         - swing
     * Material
     * Prefabs
         - Materials
     * Scenes
     * Scripts
         - AR Placeable
         - EndScreen
         - Globals
         - Markdown
         - OrderCanvas
         - Raycast
         - StartScreen
         - Water
     * XR
     * City

## Eigenleistung
Selbst erstellt haben wir das Design f�r die Dropzones, auf denen man als Spieler die Sands�cke platzieren kann. Au�erdem die Ladezone in der zu Beginn des Spiels die Sands�cke stehen und die neu angeforderten gespawnt werden. 
Des Weiteren sind der Start Screen, die verschiedenen Endscreens und das Design f�r die UI Buttons �Start� und �Neustart� selbst gemacht. 
Wir haben den Eingangsdialog des B�rgermeisters und die Enddialoge, die je nach Spielende eingespielt werden, selbst aufgenommen. 
Die Skripte sind fast alle selber geschrieben, wobei wir uns an der Unity Dokumentation orientiert haben und f�r einzelne F�lle inspiration bei www.stackoverflow.com geholt haben.
## Quellen f�r Code
F�r das Selektieren einzelner Objekte via Raycast haben wir uns an folgendem Video orientiert: 
https://www.youtube.com/watch?v=Vn9TrFJo1tw
https://answers.unity.com/questions/537673/raycast-object-tag-check.html

## Assets aus dem Unity Store
https://assetstore.unity.com/account/assets

- Gras:
https://assetstore.unity.com/packages/2d/textures-materials/glass/stylized-grass-texture-153153

- Schaukel:
https://assetstore.unity.com/packages/3d/props/exterior/swing-19032

- Zaun:
https://assetstore.unity.com/packages/3d/props/exterior/low-poly-fence-pack-61661


- Telefonzelle und Baum
https://assetstore.unity.com/packages/3d/environments/urban/city-package-107224

- Wasser Textur:
https://assetstore.unity.com/packages/2d/textures-materials/water/stylize-water-texture-153577

- H�user:
https://assetstore.unity.com/packages/3d/environments/house-pack-35346

- Sands�cke
https://assetstore.unity.com/packages/3d/props/exterior/realistic-sandbags-95964

## Testing
Die AR-App wurde auf vier verschiedenen Android Ger�ten (Honor 8X, One Plus 8, Huawei P30 Pro und Samsung S10) getestet. Au�erdem wurde sie in besser und schlechter beleuchteten Umgebungen getestet. Hierbei fiel auf, dass eine grunds�tzlich gute Beleuchtung wichtig ist. Andernfalls k�nnte das finden einer Plane l�nger dauern und die Reference Points sind nicht so zuverl�ssig. 

## Programm-Ablauf-Diagramm 
![Hier ist ein Bild](FlowChart.png)
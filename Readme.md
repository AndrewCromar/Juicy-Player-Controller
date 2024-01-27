# ONYX Juicy Player Controller

## Features
- [x] Walking.
- [x] Running.
- [x] Crouching.
- [x] Fully custom controller tuning.
- [x] Helpful error logging.
- [x] Debug variable in the inspector.

## How To Use
1. Download the attached "zip" file.
2. Extract it to you unity project's "Assets" folder.
3. Drag and drop the "Juicy Player" prefab from "Assets/Juicy Player Controller/Prefab/Juicy Player.prefab" into your scene.
4. Create tags.
    1. Create tag "ground_check".
        > This can be customized later.
    3. Create tag "camera_container".
        > This can be customized later.
5. Create layer "Ground".
     > This can be customized later.
6. Assign the "ground_check" tag to the "Ground Check" gameobject under Juicy Player.
7. Assign the "camera_container" tag to the "Camera Container" gameobject under Juicy Player.
8. Assign the "Ground" layer to any gameobjects that will be walkable.
9. Press the "Play" button and see as your fully custom Juicy Player is controllable.
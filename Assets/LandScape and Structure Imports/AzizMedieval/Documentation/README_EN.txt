MEDIEVAL HOUSES — FURNISHED MODULAR COURTYARD
Buyer Documentation and Setup Guide


CONTENTS
Three medieval buildings: a merchant's house, a stonemason's workshop and a
weavers' house. Five furnished open-plan rooms: three ground floors and two
upper floors reached by stairs. The demonstration includes 324 placed instances.

304 separate reusable FBX assets:
  78 architectural assets, including 18 interior construction assets;
  203 environment assets; 7 props; 16 furniture assets used in 36 instances.
33 materials and 99 PNG textures, all 1024 x 1024 pixels.
The complete furnished Blender scene evaluates to 1,572,046 triangles, including
placed instances. This is high-detail geometry; no LOD set or mobile/VR
performance level is promised.
Per-asset identifiers, categories and source polygon counts: asset_manifest.json.

BLENDER / CGTRADER
Extract the archive completely and preserve its folders. Open
CGTrader/Medieval_Houses_Furnished.blend in Blender 3.6.23 or a compatible newer
release. The source retains editable high-detail geometry and uses PBR materials.
Individual FBX assets are in CGTrader/Models/. Textures are in CGTrader/Textures/,
referenced from the Blender file using the relative ./Textures folder.
If images are missing after moving the package, use File > External Data > Find
Missing Files and select its Textures folder.

Import individual FBX files into your destination tool and reuse the components
independently. Preserve the hierarchy of articulated parts when using hinges.
The CGTrader delivery contains models and materials, not a running game.

UNITY URP
Unity edition only: the .unitypackage is a separate delivery and is not included
in the CGTrader ZIP.
Target configuration: Unity 6000.6.0f1 with Universal Render Pipeline 17.6.
Import the supplied .unitypackage into a URP project, retaining its Models,
Materials, Textures, Prefabs, Scenes and demonstration scripts. Open the supplied
scene in Scenes/. Drag individual assets from Prefabs/ to build your own scene.
All 304 prefab roots use zero position and rotation, with unit scale. Child
transforms retain model assembly and import transforms; do not reset them
individually. The demonstration scene shows the intended placement and orientation.
Validated in Unity 6000.6.0f1 / URP 17.6: 304 prefabs, assigned materials and colliders.
Sixteen physical navigation routes passed with the supplied character dimensions:
five doorway/stair routes and eleven exterior-ground/pavement/house routes.
The walkthrough requires Input System 1.20 and Active Input Handling set to
Input System Package (New) or Both in Player settings.

Demonstration controls in Play mode:
  Move: WASD or arrow keys. ZQSD is also supported.
  Look: hold the right mouse button and move the mouse.
  Move faster: hold Shift. Release the pointer: Escape.

Doors are open in the demonstration. Doors, shutters, chest lids and cupboard
doors have editable hinges where supplied. No scripted open/close interaction
is included; barrels and furniture are reusable models, not gameplay systems.
Adapt collisions and player dimensions to your own project.

PBR AND SCOPE
Maps: Base Color, Normal and Roughness. Base Color uses color data; Normal and
Roughness use non-color/linear data. Metallic values are material constants where
no metallic map is supplied. Materials in other engines may need channel or
normal-convention adjustments; roughness and smoothness are inverse quantities.
Only the supplied materials are included; no additional color variants or LOD
set are promised. Mobile and VR performance has not been established.
Scale is metric. This pack is an environment asset, not a complete game.

CREATION DISCLOSURE
AI assistance was used to write procedural modeling and preparation scripts.
Geometry and materials were created for this pack. No downloaded third-party
models or textures were incorporated. The assets remain editable.

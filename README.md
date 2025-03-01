# 📦 | Unity Rapid GUI Builder
This package offers a variety of modular UI scripts, all fully customizable to suit your specific needs. You can easily combine the scripts to create a wide range of effects.

The packages contains the following scripts:

- **UIDrag**: Easily move UI elements across the screen using your mouse pointer.

- **UIResize**: Resize UI elements by dragging the corners, allowing dynamic adjustments.

- **UIToolTip**: Display informations when hovering over UI elements.

- **UIDisableTimer**: Automatically disables a list of UI elements after a specified time.

- **UIKeyCodeToggle**: Open/Close a list of UI elements by pressing a keyboard key.

- **UIOpen**: Open a list of UI elements by clicking on a button.

- **UIClose**: Close a list of UI elements by clicking on a button.

# 🚀 | How to use the package
Simply attach any of the provided scripts to a Unity GameObject. (Note: You don’t need to attach the script directly to the UI component, as all required variables are exposed as public fields.) Then, assign the necessary values in the Unity Inspector, and you're good to go!

# 🟩 | Examples
Here’s how to use the UIOpen.cs script, located in the "Enable Elements" folder:

- Download the script from the repository and import it into your Unity project.

- Attach it either to the UI element it affects or any other GameObject.

- Assign values to all exposed variables in the Unity Inspector.

- The script includes the following variables:

``` C#
public List<GameObject> ElementsToEnable;

public Button TriggerButton;
```
# ❓| License
You can freely use or edit the provided script. You can republish your edited version. A mention in your game is not needed, but I would really appreciate it :D

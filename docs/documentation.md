# Jucy Documentation
Note:
> Documentation for the Jucy Player Controller is ment to be as clear and simple to understand as possible. If anything does not make sense please let us know (via discord or github). You could also just make changes to the documentation in a pull request.

## How to reference the script.
From anywhere in the scene you can reference the Jucy PC script using the following code:
```cs
public Juicy_Player_Controller jucy_pc = Juicy_Player_Controller.instance;
```
> This creates a variable called jucy_pc and sets it to the current active instance of the Juicy_Player_Controller script;
You can then call any of the functions in this documentation on the jucy_pc variable. Ex:
```cs
jucy_pc.SetJumpHeight(100f);
```
> This calls the SetJumpHeight() function from the variable which we previously set to the current instance of the Juicy_Player_Controller script.


## Getting variable values.
<details>
  <summary>GetMouseSensitivity()</summary>
  
  Returns the mouse_sensitivity variable as a float.
  ### Code
  ```cs
  public float GetMouseSensitivity(){ return mouse_sensitivity; }
  ```
</details>

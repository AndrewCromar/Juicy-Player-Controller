# Jucy Documentation
Note:
> Documentation for the Jucy Player Controller is ment to be as clear and simple to understand as possible. If anything does not make sense please let us know (via discord or github). You could also just make changes to the documentation in a pull request.

> Please report or fix any errors you might come across (via discord or github).

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
  
  ### Description
  Returns the mouse_sensitivity variable as a float.

  ### Usage
  ```cs
  jucy_pc.GetMouseSensitivity();
  ```

  ### Source Code
  ```cs
  public float GetMouseSensitivity(){ return mouse_sensitivity; }
  ```
</details>

<details>
  <summary>GetJumpHeight()</summary>
  
  ### Description
  Returns the jump_height variable as a float.

  ### Usage
  ```cs
  jucy_pc.GetJumpHeight();
  ```

  ### Source Code
  ```cs
  public float GetJumpHeight(){ return jump_height; }
  ```
</details>

<details>
  <summary>GetGravity()</summary>
  
  ### Description
  Returns the gravity variable as a float.

  ### Usage
  ```cs
  jucy_pc.GetGravity();
  ```

  ### Source Code
  ```cs
  public float GetGravity(){ return gravity; }
  ```
</details>

<details>
  <summary>GetWalkSpeed()</summary>
  
  ### Description
  Returns the walk_speed variable as a float.

  ### Usage
  ```cs
  jucy_pc.GetWalkSpeed();
  ```

  ### Source Code
  ```cs
  public float GetWalkSpeed(){ return walk_speed; }
  ```
</details>

<details>
  <summary>GetRunKeybind()</summary>
  
  ### Description
  Returns the run_keybind variable as a KeyCode.

  ### Usage
  ```cs
  jucy_pc.GetRunKeybind();
  ```

  ### Source Code
  ```cs
  public float GetRunKeybind(){ return run_keybind; }
  ```
</details>

<details>
  <summary>GetRunSpeed()</summary>
  
  ### Description
  Returns the run_speed variable as a float.

  ### Usage
  ```cs
  jucy_pc.GetRunSpeed();
  ```

  ### Source Code
  ```cs
  public float GetRunSpeed(){ return run_speed; }
  ```
</details>

<details>
  <summary>GetStaminaDrain()</summary>
  
  ### Description
  Returns the stamina_drain variable as a float.

  ### Usage
  ```cs
  jucy_pc.GetStaminaDrain();
  ```

  ### Source Code
  ```cs
  public float GetStaminaDrain(){ return stamina_drain; }
  ```
</details>

<details>
  <summary>GetStaminaRegen()</summary>
  
  ### Description
  Returns the stamina_regen variable as a float.

  ### Usage
  ```cs
  jucy_pc.GetStaminaRegen();
  ```

  ### Source Code
  ```cs
  public float GetStaminaRegen(){ return stamina_regen; }
  ```
</details>

<details>
  <summary>GetMaxStamina()</summary>
  
  ### Description
  Returns the max_stamina variable as a float.

  ### Usage
  ```cs
  jucy_pc.GetMaxStamina();
  ```

  ### Source Code
  ```cs
  public float GetMaxStamina(){ return max_stamina; }
  ```
</details>

<details>
  <summary>GetCrouchKeyBind()</summary>
  
  ### Description
  Returns the crouch_keybind variable as a KeyCode.

  ### Usage
  ```cs
  jucy_pc.GetCrouchKeyBind();
  ```

  ### Source Code
  ```cs
  public float GetCrouchKeyBind(){ return crouch_keybind; }
  ```
</details>

<details>
  <summary>GetCrouchSpeed()</summary>
  
  ### Description
  Returns the crouch_speed variable as a float.

  ### Usage
  ```cs
  jucy_pc.GetCrouchSpeed();
  ```

  ### Source Code
  ```cs
  public float GetCrouchSpeed(){ return crouch_speed; }
  ```
</details>

<details>
  <summary>GetDefaultHeight()</summary>
  
  ### Description
  Returns the default_height variable as a float.

  ### Usage
  ```cs
  jucy_pc.GetDefaultHeight();
  ```

  ### Source Code
  ```cs
  public float GetDefaultHeight(){ return default_height; }
  ```
</details>

<details>
  <summary>GetCrouchHeight()</summary>
  
  ### Description
  Returns the crouch_height variable as a float.

  ### Usage
  ```cs
  jucy_pc.GetCrouchHeight();
  ```

  ### Source Code
  ```cs
  public float GetCrouchHeight(){ return crouch_height; }
  ```
</details>

<details>
  <summary>GetGroundDistance()</summary>
  
  ### Description
  Returns the ground_distance variable as a float.

  ### Usage
  ```cs
  jucy_pc.GetGroundDistance();
  ```

  ### Source Code
  ```cs
  public float GetGroundDistance(){ return ground_distance; }
  ```
</details>

# Juicy Documentation
> [!NOTE]
> - Documentation for the Juicy Player Controller is ment to be as clear and simple to understand as possible. If anything does not make sense please let us know (via discord or github). You could also just make changes to the documentation in a pull request.
> - Please report or fix any errors you might come across (via discord or github).
> - This documentation will be updated to match the latest release.

> [!IMPORTANT]
> This package requires the Unity Input System package.

## How to reference the script.
From anywhere in the scene you can reference the Juicy_Player_Controller  script using the following code:
```cs
private Juicy_Player_Controller jucy_pc = Juicy_Player_Controller.instance; // orange
```

```cs
private JuicyPlayerController_ThirdPersonFlavor jucy_pc = JuicyPlayerController_ThirdPersonFlavor.instance; // lemonade
```
> This creates a variable called jucy_pc and sets it to the current active instance of the Juicy_Player_Controller script.

You can then call any of the functions in this documentation on the jucy_pc variable. Ex:
```cs
jucy_pc.SetJumpHeight(100f);
```
> This calls the SetJumpHeight() function from the variable which we previously set to the current instance of the Juicy_Player_Controller script.


## Getting variable values.
<details>
  <summary>GetMouseSensitivity() </summary>
  
  > **Supported Flavors:** Orange, Lemonade
  
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
  
  > **Supported Flavors:** Orange, Lemonade
  
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
  
  > **Supported Flavors:** Orange, Lemonade
  
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
  
  > **Supported Flavors:** Orange, Lemonade
  
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
  <summary>GetRunSpeed()</summary>
  
  > **Supported Flavors:** Orange, Lemonade
  
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
  
  > **Supported Flavors:** Orange, Lemonade
  
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
  
  > **Supported Flavors:** Orange, Lemonade
  
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
  
  > **Supported Flavors:** Orange, Lemonade
  
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
  <summary>GetCrouchSpeed()</summary>
  
  > **Supported Flavors:** Orange, Lemonade
  
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
  
  > **Supported Flavors:** Orange, Lemonade
  
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
  
  > **Supported Flavors:** Orange, Lemonade
  
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
  
  > **Supported Flavors:** Orange, Lemonade
  
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

## Setting variable values.
<details>
  <summary>SetMouseSensitivity()</summary>
  
  > **Supported Flavors:** Orange, Lemonade
  
  ### Description
  Sets the mouse_sensitivity variable.

  ### Usage
  ```cs
  jucy_pc.SetMouseSensitivity({new_value});
  ```

  ### Source Code
  ```cs
  public void SetMouseSensitivity(float new_sensitivity){ mouse_sensitivity = new_sensitivity; }
  ```
</details>

<details>
  <summary>SetJumpHeight()</summary>
  
  > **Supported Flavors:** Orange, Lemonade
  
  ### Description
  Sets the jump_height variable.

  ### Usage
  ```cs
  jucy_pc.SetJumpHeight({new_value});
  ```

  ### Source Code
  ```cs
  public void SetJumpHeight(float new_jump_height){ jump_height = new_jump_height; }
  ```
</details>

<details>
  <summary>SetGravity()</summary>
  
  > **Supported Flavors:** Orange, Lemonade
  
  ### Description
  Sets the gravity variable.

  ### Usage
  ```cs
  jucy_pc.SetGravity({new_value});
  ```

  ### Source Code
  ```cs
  public void SetGravity(float new_gravity){ gravity = new_gravity; }
  ```
</details>

<details>
  <summary>SetWalkSpeed()</summary>
  
  > **Supported Flavors:** Orange, Lemonade
  
  ### Description
  Sets the walk_speed variable.

  ### Usage
  ```cs
  jucy_pc.SetWalkSpeed({new_value});
  ```

  ### Source Code
  ```cs
  public void SetWalkSpeed(float new_walk_speed){ walk_speed = new_walk_speed; }
  ```
</details>

<details>
  <summary>SetRunSpeed()</summary>
  
  > **Supported Flavors:** Orange, Lemonade
  
  ### Description
  Sets the run_speed variable.

  ### Usage
  ```cs
  jucy_pc.SetRunSpeed({new_value});
  ```

  ### Source Code
  ```cs
  public void SetRunSpeed(float new_run_speed){ run_speed = new_run_speed; }
  ```
</details>

<details>
  <summary>SetStaminaDrain()</summary>
  
  > **Supported Flavors:** Orange, Lemonade
  
  ### Description
  Sets the stamina_drain variable.

  ### Usage
  ```cs
  jucy_pc.SetStaminaDrain({new_value});
  ```

  ### Source Code
  ```cs
  public void SetStaminaDrain(float new_stamina_drain){ stamina_drain = new_stamina_drain; }
  ```
</details>

<details>
  <summary>SetStaminaRegen()</summary>
  
  > **Supported Flavors:** Orange, Lemonade
  
  ### Description
  Sets the stamina_regen variable.

  ### Usage
  ```cs
  jucy_pc.SetStaminaRegen({new_value});
  ```

  ### Source Code
  ```cs
  public void SetStaminaRegen(float new_stamina_regen){ stamina_regen = new_stamina_regen; }
  ```
</details>

<details>
  <summary>SetMaxStamina()</summary>
  
  > **Supported Flavors:** Orange, Lemonade
  
  ### Description
  Sets the max_stamina variable.

  ### Usage
  ```cs
  jucy_pc.SetMaxStamina({new_value});
  ```

  ### Source Code
  ```cs
  public void SetMaxStamina(float new_max_stamina){ max_stamina = new_max_stamina; }
  ```
</details>

<details>
  <summary>SetCrouchSpeed()</summary>
  
  > **Supported Flavors:** Orange, Lemonade
  
  ### Description
  Sets the crouch_speed variable.

  ### Usage
  ```cs
  jucy_pc.SetCrouchSpeed({new_value});
  ```

  ### Source Code
  ```cs
  public void SetCrouchSpeed(float new_crouch_speed){ crouch_speed = new_crouch_speed; }
  ```
</details>

<details>
  <summary>SetDefaultHeight()</summary>
  
  > **Supported Flavors:** Orange, Lemonade
  
  ### Description
  Sets the default_height variable.

  ### Usage
  ```cs
  jucy_pc.SetDefaultHeight({new_value});
  ```

  ### Source Code
  ```cs
  public void SetDefaultHeight(float new_default_height){ default_height = new_default_height; }
  ```
</details>

<details>
  <summary>SetCrouchHeight()</summary>
  
  > **Supported Flavors:** Orange, Lemonade
  
  ### Description
  Sets the crouch_height variable.

  ### Usage
  ```cs
  jucy_pc.SetCrouchHeight({new_value});
  ```

  ### Source Code
  ```cs
  public void SetCrouchHeight(float new_crouch_height){ crouch_height = new_crouch_height; }
  ```
</details>

<details>
  <summary>SetGroundDistance()</summary>
  
  > **Supported Flavors:** Orange, Lemonade
  
  ### Description
  Sets the ground_distance variable.

  ### Usage
  ```cs
  jucy_pc.SetGroundDistance({new_value});
  ```

  ### Source Code
  ```cs
  public void SetGroundDistance(float new_ground_distance){ ground_distance = new_ground_distance; }
  ```
</details>

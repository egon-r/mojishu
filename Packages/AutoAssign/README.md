# Auto Assign
This Package provides a simple "Auto Assign" Button that compares the type and name of your fields to the type and name of any child component and assigns them accordingly. 

![demo](demo.gif)

No more time wasted dragging and dropping, reassigning or accidentally messing up the hierarchy.

## Install
Open the Package Manager and use `Add package from git URL...` to add the package to your project.

## Usage
1. Decorate your class with `[AutoAssignable]`
    ```
    [AutoAssignable]
    public class MainMenu: AnimatedMenu
    {
        public Button Play;
        public Button Credits;
        public Button Exit;
        public TextMeshProUGUI VersionText;
    }
    ```
2. Add the `Auto Assign` component to the same component.
3. Click on `Auto Assign` to automatically assign all variables.

## ManualAssign
If a field cannot be matched with a child it is set to null so the status of the field after pressing "Auto Assign" is clear. To avoid this behaviour decorate the field with `[ManualAssign]`. 
```
[AutoAssignable]
public class MainMenu: AnimatedMenu
{
    public Button Play;
    public Button Credits;
    public Button Exit;
    [ManualAssign]
    public TextMeshProUGUI VersionText;
}
```

---
## License
This project is licensed using the CC-BY license. This is a human-readable summary of (and not a substitute for) the license: 
```
You are free to:
Share — copy and redistribute the material in any medium or format
Adapt — remix, transform, and build upon the material
for any purpose, even commercially.

Under the following terms:
Attribution — You must give appropriate credit, provide a link to the license, and indicate if changes were made. You may do so in any reasonable manner, but not in any way that suggests the licensor endorses you or your use.

No additional restrictions — You may not apply legal terms or technological measures that legally restrict others from doing anything the license permits.
``` 

## Donate
If this project assisted you in making money, you can donate whatever amount you find appropriate 
[here (PayPal)](https://www.paypal.com/donate/?hosted_button_id=8NPR5ABGRD89S). It will be much appreciated and motivate me to continue releasing software that is free, open source and uses permissive licenses.
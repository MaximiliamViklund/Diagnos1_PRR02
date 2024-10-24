using System.Runtime.CompilerServices;
using System.Timers;

class BasicBitch{
    public int X;
    public int Y;
    public int Direction;

    public void Walk(){
        switch(Direction){
            case 0:
            X+=20;
            Direction++;
            break;
            case 1:
            X-=20;
            Direction--;
            break;
        }
    }
}

class Exploder:BasicBitch{
    public int Timer;
    public bool IsActive;

    public void Activate(){
        IsActive=true;
    }
    public void Update(){
        if(IsActive){
            for (;Timer >=0; Timer--){
                Console.WriteLine(Timer);
                Console.ReadLine();
            }
            Console.WriteLine("KABOOM!!");
            Console.ReadLine();
        }
    }
}

class BlackEyedPeas:BasicBitch{   //aka Jumper
    public int JumpForce;

    public void Jump(){
        JumpForce=20;
    }
    public void Update(){
        if(JumpForce>0){
            Y+=10;
            JumpForce--;
        }
        else{
            Y=0;
        }
    }
}

class Digger:BasicBitch{
    public bool IsDigging;

    public void StartDigging(){
        IsDigging=true;
    }
    public void Update(){
        if(IsDigging){
            Y-=10;
        }
    }
}
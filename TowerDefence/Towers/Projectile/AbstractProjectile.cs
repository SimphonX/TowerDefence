

using System;
using System.Collections.Generic;
/**
* @(#) AbstractProjectile.cs
*/
namespace towers_classes
{
	public abstract class AbstractProjectile: AbstractProjectileContainer
	{
        protected int id;

        protected int start_x;

        protected int start_y;

        protected int target_x;

        protected int target_y;

        protected double velocity;

        protected int baseDamage;

        protected string effect;

        protected double current_x;
        protected double current_y;

        private double angle = -999;

        public AbstractProjectile(int x, int y, int tx, int ty, string effect, int baseDamage) : base(x, y)
        {
            this.start_x = x; this.start_y = y; this.target_x = tx; this.target_y = ty; this.effect=effect;
            this.current_x = x; this.current_y = y;
        }

        public override string[] getEffects()
        {
            return new string[] { this.effect };
        }

        public double getAngle()
        {
            return (Math.Atan2(target_y - current_y, target_x - current_x))* (180/Math.PI);
        }

        //x,y change on tick
        public override bool updateLocation()
        {
            if (this.angle == -999)
            {
                this.angle = this.getAngle();
            }
            double next_x = current_x + Math.Cos(angle * Math.PI) * (this.velocity);
            double next_y = current_y + Math.Sin(angle * Math.PI) * (this.velocity);
            if((Math.Abs(target_x-next_x)>Math.Abs(target_x-current_x))&&(Math.Abs(target_y - next_y) > Math.Abs(target_y - current_y))){
                Console.WriteLine(this.GetType().Name + " id:" + this.id + " reached destination coordinates");
                return true;
            }
            current_x = next_x;
            current_y = next_y;
            Console.WriteLine("X: " + current_x + "; Y: " + current_y);
            return false;
        }
    }
	
}

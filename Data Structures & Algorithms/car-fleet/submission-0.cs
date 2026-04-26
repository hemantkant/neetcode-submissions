public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        var cars = new List<(int pos, int spd)>();
        for(int i = 0; i<n; i++){
            cars.Add((position[i], speed[i]));
        }
        cars.Sort((a,b) => b.pos.CompareTo(a.pos));
        int fleets = 0;
        double lastTime = 0;
        foreach(var car in cars){
            double time = (double)(target-car.pos)/car.spd;
            if(time>lastTime){
                fleets++;
                lastTime = time;
            }
        }
        return fleets;
    }
}

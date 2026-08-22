
List<Player> players = new List<Player>();

Player Player_1 = new Player("Ram");
Player Player_2 = new Player("Bea");
Player Player_3 = new Player("Meraki");
Player Player_4 = new Player("Mera");

players.Add(Player_1);
players.Add(Player_2);
players.Add(Player_3);
players.Add(Player_4);

//or
//players.Add(new Player("Ram"));


foreach (Player player in players)
{
    Console.WriteLine(player.name);
}
class Player
{
    public String name;

    public Player(String username)
    {
        this.name = username;
    }
}
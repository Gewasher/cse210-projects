using System;

public class Dungeon
{
    private List<Room> _rooms;
    private int _curentRoom;
    private int _maxRooms;

    public Dungeon(int maxRooms)
    {
        _maxRooms = maxRooms;
        _curentRoom = 0;
        _rooms = new List<Room>();
        CreateRooms();
    }

    public void CreateRooms()
    {
        int var = 1;
        while(var < _maxRooms)
        {
            Room item = new Room();
            _rooms.Add(item);
            var += 1;
        }
        Bossroom bossroom = new Bossroom();
        _rooms.Add(bossroom);
    }

    public string DisplayInfo()
    {
        return $"Dungeon: Curent Room-{_curentRoom+1}/{_maxRooms}";
    }


    public void NextRoom()
    {
        _curentRoom +=1;
    }
    public Enemy GetEnemy()
    {
        return _rooms[_curentRoom].GetEnemy();
    }
    public int GetCurrentRoom()
    {
        return _curentRoom;
    }

    public int GetMaxRooms()
    {
        return _maxRooms;
    }


}
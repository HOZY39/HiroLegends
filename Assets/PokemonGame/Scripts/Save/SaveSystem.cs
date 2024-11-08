using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SavePokemon (PokemonScript Pokemon, PokemonScript Pokemon2, PokemonScript Pokemon3, PokemonScript Pokemon4, PokemonScript Pokemon5, PokemonScript Pokemon6)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        string path1 = Application.persistentDataPath + "/Data/MyPokemon1.Pokemon1";
        string path2 = Application.persistentDataPath + "/Data/MyPokemon2.Pokemon2";
        string path3 = Application.persistentDataPath + "/Data/MyPokemon3.Pokemon3";
        string path4 = Application.persistentDataPath + "/Data/MyPokemon4.Pokemon4";
        string path5 = Application.persistentDataPath + "/Data/MyPokemon5.Pokemon5";
        string path6 = Application.persistentDataPath + "/Data/MyPokemon6.Pokemon6";

        FileStream stream1 = new FileStream(path1, FileMode.Create);
        FileStream stream2 = new FileStream(path2, FileMode.Create);
        FileStream stream3 = new FileStream(path3, FileMode.Create);
        FileStream stream4 = new FileStream(path4, FileMode.Create);
        FileStream stream5 = new FileStream(path5, FileMode.Create);
        FileStream stream6 = new FileStream(path6, FileMode.Create);

        PokemonData data1 = new PokemonData(Pokemon);
        Pokemon2Data data2 = new Pokemon2Data(Pokemon2);
        Pokemon3Data data3 = new Pokemon3Data(Pokemon3);
        Pokemon4Data data4 = new Pokemon4Data(Pokemon4);
        Pokemon5Data data5 = new Pokemon5Data(Pokemon5);
        Pokemon6Data data6 = new Pokemon6Data(Pokemon6);

        formatter.Serialize(stream1, data1);
        formatter.Serialize(stream2, data2);
        formatter.Serialize(stream3, data3);
        formatter.Serialize(stream4, data4);
        formatter.Serialize(stream5, data5);
        formatter.Serialize(stream6, data6);

        stream1.Close();
        stream2.Close();
        stream3.Close();
        stream4.Close();
        stream5.Close();
        stream6.Close();
    }

    public static PokemonData LoadPokemon()
    {
        string path1 = Application.persistentDataPath + "/Data/MyPokemon1.Pokemon1";
        if (File.Exists(path1))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(path1, FileMode.Open);

            PokemonData data = formatter.Deserialize(stream) as PokemonData;

            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save File Not Found");
            return null;
        }
    }

    public static Pokemon2Data Load2Pokemon()
    {
        string path2 = Application.persistentDataPath + "/Data/MyPokemon2.Pokemon2";
        if (File.Exists(path2))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(path2, FileMode.Open);

            Pokemon2Data data2 = formatter.Deserialize(stream) as Pokemon2Data;

            stream.Close();

            return data2;
        }
        else
        {
            Debug.LogError("Save File Not Found");
            return null;
        }
    }

    public static Pokemon3Data Load3Pokemon()
    {
        string path3 = Application.persistentDataPath + "/Data/MyPokemon3.Pokemon3";
        if (File.Exists(path3))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(path3, FileMode.Open);

            Pokemon3Data data = formatter.Deserialize(stream) as Pokemon3Data;

            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save File Not Found");
            return null;
        }
    }

    public static Pokemon4Data Load4Pokemon()
    {
        string path4 = Application.persistentDataPath + "/Data/MyPokemon4.Pokemon4";
        if (File.Exists(path4))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(path4, FileMode.Open);

            Pokemon4Data data = formatter.Deserialize(stream) as Pokemon4Data;

            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save File Not Found");
            return null;
        }
    }

    public static Pokemon5Data Load5Pokemon()
    {
        string path5 = Application.persistentDataPath + "/Data/MyPokemon5.Pokemon5";
        if (File.Exists(path5))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(path5, FileMode.Open);

            Pokemon5Data data = formatter.Deserialize(stream) as Pokemon5Data;

            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save File Not Found");
            return null;
        }
    }

    public static Pokemon6Data Load6Pokemon()
    {
        string path6 = Application.persistentDataPath + "/Data/MyPokemon6.Pokemon6";
        if (File.Exists(path6))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(path6, FileMode.Open);

            Pokemon6Data data = formatter.Deserialize(stream) as Pokemon6Data;

            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save File Not Found");
            return null;
        }
    }
}

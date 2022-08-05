using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*[SerializeField]
public class GameManager : MonoBehaviour
{
    public int NumRoundsToWin = 5;
    public float StartDelay = 3f;
    public float EndDelay = 3f;
    public TankCameraController CameraControl;
    public Text MessageText;
    public GameObject TankPrefab;
    public TankManager[] Tanks;

    private int roundnumber;
    private WaitForSeconds StartWait;
    private WaitForSeconds EndWait;
    private TankManager GameWinner;
    private TankManager Roundwinner;

    private void Start()
    {
        StartWait = new WaitForSeconds(StartDelay);
        EndWait = new WaitForSeconds(EndDelay);
        
        spawnAlltanks();
        setcameratargets();

        StartCoroutine(GameLoop());
    }
    private void spawnAlltanks()
    {
        for (int i = 0; i < Tanks.Length; i++)
        {
            Tanks[i].instance =
                Instantiate(TankPrefab, Tanks[i].m_spawnpoint.position, Tanks[i].m_spawnpoint.rotation) as GameObject;
            Tanks[i].playernumber = i + 1;
            Tanks[i].setup();
        }
    } 
    private void setcameratargets()
    {
        Transform[] targets = new Transform[Tanks.Length];
        
        for(int i = 0; i < targets.Length; i++)
        {
            targets[i] = Tanks[i].instance.transform;
        }
        CameraControl.m_Targets = targets;    
    }
    private IEnumerator GameLoop()
    {
        yield return StartCoroutine(RoundStarting());
        yield return StartCoroutine(RoundPlaying());
        yield return StartCoroutine(RoundEnding());
        
        if(GameWinner != null)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        else
        {
            StartCoroutine(GameLoop());
        }
    }
    private IEnumerator RoundStarting()
    {

        CameraControl.setStartPositionAndSize();
        roundnumber++;
        MessageText.text = "ROUND " + roundnumber;
        
        yield return StartWait;
    }
    private IEnumerator RoundPlaying()
    {

        MessageText.text = string.Empty;

        while (!OneTankLeft())
        {
            yield return null;
        }
    }
    private IEnumerator RoundEnding()
    {
      

        Roundwinner = null;

        Roundwinner = getRoundWinner();

        if (Roundwinner != null)
            Roundwinner.wins++;

        GameWinner = getGameWinner();

        string message = Endmessage();
        MessageText.text = message;

        yield return EndWait;
    }
    private bool OneTankLeft()
    {
        int numTanksLeft = 0;
        
        for(int i = 0; i <Tanks.Length; i++)
        {
            if (Tanks[i].instance.activeSelf)
                numTanksLeft++;
        }
        return numTanksLeft <= 1;
    }
    private TankManager getRoundWinner()
    {
        for(int i = 0; i < Tanks.Length; i++)
        {
            if (Tanks[i].instance.activeSelf)
                return Tanks[i];
        }
        return null;
    }
    private TankManager getGameWinner()
    {
        for(int i = 0; i < Tanks.Length; i++)
        {
            if (Tanks[i].wins == NumRoundsToWin)
                return Tanks[i];
        }
        return null;
    }
    private string Endmessage()
    {
        string message = "DRAW!";

        if (Roundwinner != null)
            message = Roundwinner.coloredplayertext + " WINS THE ROUND!";
       
        message += "\n\n\n\n";

        for(int i = 0; i < Tanks.Length; i++)
        {
            message += Tanks[i].coloredplayertext + ": " + Tanks[i].wins + " WINS\n";
        }
        if (GameWinner != null)
            message = GameWinner.coloredplayertext + " WINS THE GAME!";

        return message;
    }
   
} */


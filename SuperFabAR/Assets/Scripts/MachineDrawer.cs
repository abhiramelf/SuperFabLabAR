using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineDrawer : MonoBehaviour
{
    private DefaultTrackableEventHandler eventHandlerOne;
    private DefaultTrackableEventHandler eventHandlerTwo;
    private DefaultTrackableEventHandler eventHandlerThree;
    private DefaultTrackableEventHandler eventHandlerFour;
    private DefaultTrackableEventHandler eventHandlerFive;
    private DefaultTrackableEventHandler eventHandlerSix;

    public Animator machineDrawer;

    public GameObject buttonUP;
    public GameObject buttonDOWN;
    public GameObject machines;
    public GameObject machineOne;
    public GameObject machineTwo;
    public GameObject machineThree;
    public GameObject machineFour;
    public GameObject machineFive;
    public GameObject machineSix;

    // Start is called before the first frame update
    void Start()
    {

        eventHandlerOne = GameObject.Find("ZUND").GetComponent<DefaultTrackableEventHandler>();
        eventHandlerTwo = GameObject.Find("LATHE").GetComponent<DefaultTrackableEventHandler>();
        eventHandlerThree = GameObject.Find("OMAX").GetComponent<DefaultTrackableEventHandler>();
        eventHandlerFour = GameObject.Find("LASER").GetComponent<DefaultTrackableEventHandler>();
        eventHandlerFive = GameObject.Find("PRUSA").GetComponent<DefaultTrackableEventHandler>();
        eventHandlerSix = GameObject.Find("SINDOH").GetComponent<DefaultTrackableEventHandler>();

        buttonUP.SetActive(true);
        buttonDOWN.SetActive(false);
        machineOne.SetActive(false);
    }

    void Update()
    {
        if (eventHandlerOne.newCustomStatus == Vuforia.TrackableBehaviour.Status.DETECTED ||
            eventHandlerOne.newCustomStatus == Vuforia.TrackableBehaviour.Status.TRACKED ||
            eventHandlerOne.newCustomStatus == Vuforia.TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            if (buttonUP.activeInHierarchy)
            {
                machineDrawer.Play("MachineDrawer");
            }
            buttonUP.SetActive(false);
            buttonDOWN.SetActive(true);
            machines.SetActive(false);
            machineOne.SetActive(true);
            machineTwo.SetActive(false);
            machineThree.SetActive(false);
            machineFour.SetActive(false);
            machineFive.SetActive(false);
            machineSix.SetActive(false);
        }

        if (eventHandlerTwo.newCustomStatus == Vuforia.TrackableBehaviour.Status.DETECTED ||
            eventHandlerTwo.newCustomStatus == Vuforia.TrackableBehaviour.Status.TRACKED ||
            eventHandlerTwo.newCustomStatus == Vuforia.TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            if (buttonUP.activeInHierarchy)
            {
                machineDrawer.Play("MachineDrawer");
            }
            buttonUP.SetActive(false);
            buttonDOWN.SetActive(true);
            machines.SetActive(false);
            machineOne.SetActive(false);
            machineTwo.SetActive(true);
            machineThree.SetActive(false);
            machineFour.SetActive(false);
            machineFive.SetActive(false);
            machineSix.SetActive(false);
        }

        if (eventHandlerThree.newCustomStatus == Vuforia.TrackableBehaviour.Status.DETECTED ||
            eventHandlerThree.newCustomStatus == Vuforia.TrackableBehaviour.Status.TRACKED ||
            eventHandlerThree.newCustomStatus == Vuforia.TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            if (buttonUP.activeInHierarchy)
            {
                machineDrawer.Play("MachineDrawer");
            }
            buttonUP.SetActive(false);
            buttonDOWN.SetActive(true);
            machines.SetActive(false);
            machineOne.SetActive(false);
            machineTwo.SetActive(false);
            machineThree.SetActive(true);
            machineFour.SetActive(false);
            machineFive.SetActive(false);
            machineSix.SetActive(false);
        }

        if (eventHandlerFour.newCustomStatus == Vuforia.TrackableBehaviour.Status.DETECTED ||
            eventHandlerFour.newCustomStatus == Vuforia.TrackableBehaviour.Status.TRACKED ||
            eventHandlerFour.newCustomStatus == Vuforia.TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            if (buttonUP.activeInHierarchy)
            {
                machineDrawer.Play("MachineDrawer");
            }
            buttonUP.SetActive(false);
            buttonDOWN.SetActive(true);
            machines.SetActive(false);
            machineOne.SetActive(false);
            machineTwo.SetActive(false);
            machineThree.SetActive(false);
            machineFour.SetActive(true);
            machineFive.SetActive(false);
            machineSix.SetActive(false);
        }

        if (eventHandlerFive.newCustomStatus == Vuforia.TrackableBehaviour.Status.DETECTED ||
            eventHandlerFive.newCustomStatus == Vuforia.TrackableBehaviour.Status.TRACKED ||
            eventHandlerFive.newCustomStatus == Vuforia.TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            if (buttonUP.activeInHierarchy)
            {
                machineDrawer.Play("MachineDrawer");
            }
            buttonUP.SetActive(false);
            buttonDOWN.SetActive(true);
            machines.SetActive(false);
            machineOne.SetActive(false);
            machineTwo.SetActive(false);
            machineThree.SetActive(false);
            machineFour.SetActive(false);
            machineFive.SetActive(true);
            machineSix.SetActive(false);
        }

        if (eventHandlerSix.newCustomStatus == Vuforia.TrackableBehaviour.Status.DETECTED ||
            eventHandlerSix.newCustomStatus == Vuforia.TrackableBehaviour.Status.TRACKED ||
            eventHandlerSix.newCustomStatus == Vuforia.TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            if (buttonUP.activeInHierarchy)
            {
                machineDrawer.Play("MachineDrawer");
            }
            buttonUP.SetActive(false);
            buttonDOWN.SetActive(true);
            machines.SetActive(false);
            machineOne.SetActive(false);
            machineTwo.SetActive(false);
            machineThree.SetActive(false);
            machineFour.SetActive(false);
            machineFive.SetActive(false);
            machineSix.SetActive(true);
        }
    }

    public void MachineDrawerUP()
    {
        machineDrawer.Play("MachineDrawer");
        buttonUP.SetActive(false);
        buttonDOWN.SetActive(true);
    }

    public void MachineDrawerDOWN()
    {
        machineDrawer.Play("MachineDrawerBack");
        buttonUP.SetActive(true);
        buttonDOWN.SetActive(false);
    }

    public void MachineOneDetails()
    {
        machines.SetActive(false);
        machineOne.SetActive(true);
    }

    public void MachineTwoDetails()
    {
        machines.SetActive(false);
        machineTwo.SetActive(true);
    }

    public void MachineThreeDetails()
    {
        machines.SetActive(false);
        machineThree.SetActive(true);
    }

    public void MachineFourDetails()
    {
        machines.SetActive(false);
        machineFour.SetActive(true);
    }

    public void MachineFiveDetails()
    {
        machines.SetActive(false);
        machineFive.SetActive(true);
    }

    public void MachineSixDetails()
    {
        machines.SetActive(false);
        machineSix.SetActive(true);
    }

    public void MachineDetailsBack()
    {
        machines.SetActive(true);
        machineOne.SetActive(false);
        machineTwo.SetActive(false);
        machineThree.SetActive(false);
        machineFour.SetActive(false);
        machineFive.SetActive(false);
        machineSix.SetActive(false);
    }
}

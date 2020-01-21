# SuperFabLabAR
The Augmented Reality enabled application for educating people about the devices in KSUM's SuperFabLab.

An AR enabled application for KSUM SuperFabLab made with Unity and Vuforia.

# Dependencies
1. Unity 3D
2. Vuforia for Unity
3. TextMesh Pro

# IMPORTANT NOTE!
Some steps need to be done inorder to completely make the application working.

1. In "DefaultTrackableEventHandler.cs" script that comes with Vuforia, you need to make some changes.
2. Make the "OnTrackingLost()" function "public". This is by default a "protected" one.
3. Add a new "public" variable - "newCustomStatus" to the script, which is of type "TrackableBehaviour.Status".

# Vuforia Image Targets
The machines logos serve as the image targets for recognition.

# Machine List
1. ZUND Cutter
2. OMAX 5555 Water Jet Cutter
3. TORMACH 15L Slant Pro Lathe
4. TROTEC Speedy 400 Flexx Laser Cutter
5. PRUSA 3D Print Farm
6. SINDOH 3D Print Farm

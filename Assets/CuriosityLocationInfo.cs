using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CuriosityLocationInfo : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	bool showTextCuriosityLocationInfo = true;
	Rect textAreaCuriosityLocationInfo = new Rect(0,0,Screen.width, Screen.height);

	void OnGUI()
	{
		if(showTextCuriosityLocationInfo)
		{
			// ?? objCuriosity = CuriosityControl.GetComponent();
			// objCuriosity = GameObject.Find("Your_Name_Here").transform.position;
			// objCuriosity = GameObject.FindGameObjectWithTag("Your_Tag_Here").transform.position;

			// GameObject objCuriosity = GameObject.Find("Curiosity");
		    // Vector3 vectPosXYZ = objCuriosity.transform.position; 
		//int zoom = 5;
			// Debug.Log (vectPosXYZ);
			// GUI.Label(textAreaCuriosityLocationInfo,"Line1\nLine2\nLine3\nLine4");

			// GUI.Label( textAreaCuriosityLocationInfo, prepareTextLine_from_vectPosXYZ( vectPosXYZ, zoom ) + "\n" );
	
			string text_overlay = "";
			// http://stackoverflow.com/questions/28759545/unity-an-object-reference-is-required-to-access-non-static-member-ray-cast-to
			// DID NOT WORK: TerrainLoader objTerrainLoader = GetComponent<TerrainLoader>();
			// DID NOT WORK: TerrainLoader objTerrainLoader = GameObject.Find("TerrainLoader");

			Vector2 vectLonxLaty = TerrainLoader.getLonxLaty_of_Curiosity();

			// text_overlay += TerrainLoader.glob_obj_il.event_name + "\n";
				
			text_overlay +=   "Lon: " + vectLonxLaty.x.ToString("###0.000000") + "E " + "\n"
				            + "Lat: " + vectLonxLaty.y.ToString("###0.000000") + "N " + "\n";
			GUI.Label (textAreaCuriosityLocationInfo, text_overlay);


			/*
			GUI.Label( textAreaCuriosityLocationInfo,
				  prepareTextLine_from_vectPosXYZ( new Vector3( 0*256, 0, 0*256 ), 0 ) + "\n"
				+ prepareTextLine_from_vectPosXYZ( new Vector3( 1*256, 0, 0*256 ), 0 ) + "\n"
				+ prepareTextLine_from_vectPosXYZ( new Vector3( 2*256, 0, 0*256 ), 0 ) + "\n"
				+ prepareTextLine_from_vectPosXYZ( new Vector3( 0*256, 0, 1*256 ), 0 ) + "\n"
				+ prepareTextLine_from_vectPosXYZ( new Vector3( 1*256, 0, 1*256 ), 0 ) + "\n"
				+ prepareTextLine_from_vectPosXYZ( new Vector3( 2*256, 0, 1*256 ), 0 ) + "\n"
			);
			*/
			/*
			GUI.Label( textAreaCuriosityLocationInfo,
			 	prepareTextLine_from_vectPosXYZ( new Vector3( 0*256, 0, 0*256 ), 1 ) + "\n"
				+ prepareTextLine_from_vectPosXYZ( new Vector3( 1*256, 0, 0*256 ), 1 ) + "\n"
				+ prepareTextLine_from_vectPosXYZ( new Vector3( 2*256, 0, 0*256 ), 1 ) + "\n"
				+ prepareTextLine_from_vectPosXYZ( new Vector3( 3*256, 0, 0*256 ), 1 ) + "\n"
				+ prepareTextLine_from_vectPosXYZ( new Vector3( 4*256, 0, 0*256 ), 1 ) + "\n"

				+ prepareTextLine_from_vectPosXYZ( new Vector3( 0*256, 0, 1*256 ), 1 ) + "\n"
				+ prepareTextLine_from_vectPosXYZ( new Vector3( 1*256, 0, 1*256 ), 1 ) + "\n"
				+ prepareTextLine_from_vectPosXYZ( new Vector3( 2*256, 0, 1*256 ), 1 ) + "\n"
				+ prepareTextLine_from_vectPosXYZ( new Vector3( 3*256, 0, 1*256 ), 1 ) + "\n"
				+ prepareTextLine_from_vectPosXYZ( new Vector3( 4*256, 0, 1*256 ), 1 ) + "\n"

				+ prepareTextLine_from_vectPosXYZ( new Vector3( 0*256, 0, 2*256 ), 1 ) + "\n"
				+ prepareTextLine_from_vectPosXYZ( new Vector3( 1*256, 0, 2*256 ), 1 ) + "\n"
				+ prepareTextLine_from_vectPosXYZ( new Vector3( 2*256, 0, 2*256 ), 1 ) + "\n"
				+ prepareTextLine_from_vectPosXYZ( new Vector3( 3*256, 0, 2*256 ), 1 ) + "\n"
				+ prepareTextLine_from_vectPosXYZ( new Vector3( 4*256, 0, 2*256 ), 1 ) + "\n"
			);
			*/

			/*
			GUI.Label (textAreaCuriosityLocationInfo,
				  "Loc0:" + prepareTextLine_from_vectLonxLaty_Tzoom (new Vector3 ( -180.0f, 85.051f, 0.0f), zoom ) + "\n"
				+ "Loc1:" + prepareTextLine_from_vectLonxLaty_Tzoom (new Vector3 (  -90.0f, 85.051f, 0.0f), zoom ) + "\n"
				+ "Loc2:" + prepareTextLine_from_vectLonxLaty_Tzoom (new Vector3 (    0.0f, 85.051f, 0.0f), zoom ) + "\n"
				+ "Loc3:" + prepareTextLine_from_vectLonxLaty_Tzoom (new Vector3 (   90.0f, 85.051f, 0.0f), zoom ) + "\n"
				+ "Loc4:" + prepareTextLine_from_vectLonxLaty_Tzoom (new Vector3 (  180.0f, 85.051f, 0.0f), zoom ) + "\n"
			);
			*/
			/*
			GUI.Label (textAreaCuriosityLocationInfo,
				"Curiosity (rover) Bradbury Landing:" + prepareTextLine_from_vectLonxLaty_Tzoom (new Vector2 ( 137.4417f, -4.5895f ), zoom ) + "\n"
				+ "Spirit (rover):" + prepareTextLine_from_vectLonxLaty_Tzoom (new Vector2 (  175.472636f, -14.5684f ), zoom ) + "\n"
				+ "Opportunity_(rover):" + prepareTextLine_from_vectLonxLaty_Tzoom (new Vector2 ( 354.4734f, -1.9462f ), zoom ) + "\n"
				// + "Loc3:" + prepareTextLine_from_vectLonxLaty_Tzoom (new Vector2 (   90.0f, 85.051f ), zoom ) + "\n"
				// + "Loc4:" + prepareTextLine_from_vectLonxLaty_Tzoom (new Vector2 (  180.0f, 85.051f ), zoom ) + "\n"
			);
			*/

			/*
			string str = "";
			foreach (InterestingLocation il_element in InterestingLocation.InterestingLocationList)
			{
				str += il_element.event_name + ": " + prepareTextLine_from_vectLonxLaty_Tzoom( il_element.vectLonxLaty, zoom ) + "\n";
			}
			GUI.Label (textAreaCuriosityLocationInfo, str );
		    */
		}
	}

	//
	public string prepareTextLine_from_vectPosXYZ( Vector3 vectPosXYZ, int Tile_zoom )
	{
		
		Vector2 vectTxTy     = new Vector3( vectPosXYZ.x/256, -vectPosXYZ.z/256, Tile_zoom );
		Vector2 vectLonxLaty = TerrainTile.TileToWorldPos( vectTxTy, Tile_zoom );
		return prepareText_Vector3 ("vectPosXYZ", vectPosXYZ) +
			prepareText_Vector3 ("; vectTxTyTzoom", new Vector3( vectTxTy.x, vectTxTy.y, Tile_zoom ) ) +
			prepareText_Vector3 ("; vectLonxLaty_Tzoom", new Vector3( vectLonxLaty.x, vectLonxLaty.y, Tile_zoom ) );
	}

	public string prepareTextLine_from_vectLonxLaty_Tzoom( Vector2 vectLonxLaty, int Tile_zoom )
	{
		Vector2 vectTxTy   = TerrainTile.WorldToTilePos( vectLonxLaty, Tile_zoom );
		Vector3 vectPosXYZ = new Vector3( vectTxTy.x * 256.0f, 0.0f, -vectTxTy.y * 256.0f );

		Vector2 vectMapXY = TerrainTile.vectLonxLaty_to_map_at_zoom_0( vectLonxLaty );

		return  prepareText_Vector3 ("vectLonxLatyTzoom", new Vector3 (vectLonxLaty.x, vectLonxLaty.y, Tile_zoom ) ) +
			    prepareText_Vector3 ("; vectTxTyTzoom", new Vector3( vectTxTy.x, vectTxTy.y, Tile_zoom ) ) +
		        prepareText_Vector3 ("; vectPosXYZ", vectPosXYZ) +
			    prepareText_Vector3 ("; vectMapXY_zoom0", new Vector3( vectMapXY.x, vectMapXY.y, 0.0f ) );
	}

	public string prepareText_Vector3( string text_prefix, Vector3 vect3 )
	{
		return text_prefix + " [ "
		+ vect3.x.ToString ("#000.00000") + ", "
		+ vect3.y.ToString ("#000.00000") + ", "
		+ vect3.z.ToString ("#000.00000") + " ]";
	}
	//
}
	
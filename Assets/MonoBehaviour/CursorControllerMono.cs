using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorControllerMono : MonoBehaviour {
	private bool isBlack = true;
	[SerializeField] private Color blackColor = Color.black;
	[SerializeField] private Color whiteColor = Color.white;

	// Start is called before the first frame update
	void Start() {
		// ���̂������Ȃ�
		// Start()���_�ł�SerializeField�ɂ������Ȓl���i�[����Ă���ۂ�
		// this.GetComponent<SpriteRenderer>().color = blackColor;
		isBlack = true;
	}

	// Update is called once per frame
	void Update() {
		// �L�[���͂ɂ��ړ�
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			this.transform.position += new Vector3(0, 1.0f);
		}
		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			this.transform.position += new Vector3(0, -1.0f);
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			this.transform.position += new Vector3(-1.0f, 0);
		}
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			this.transform.position += new Vector3(1.0f, 0);
		}

		// �΂�u���ĐF��ύX����
		if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return)) {
			this.GetComponent<SpriteRenderer>().color = isBlack ? Color.white : Color.black;
			isBlack = !isBlack;
		}
	}
}
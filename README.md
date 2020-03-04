# YLibrary

유니티에 편리한 기능을 추가합니다.
제가 개인적으로 사용하고 개발하고 있습니다. 필요에 따라 지속적으로 업데이트 됩니다.

 > 개발 버전 : Unity 2019 3.2f1

## 적용 방법

 Asset -> Import Custom Asset에서 [YLibrary.unitypackage](https://github.com/wethinknewrise/YLibrary/blob/master/YLibrary.unitypackage "YLibrary.unitypackage") 를 바로 적용하시면 됩니다.

# 에디터 기능

 ## UGUI
  Ctrl+Shift+C : 새로운 캔버스 생성
  Ctrl+Shift+P : "Panel" 빈 오브젝트 생성
  Ctrl+Shift+D : "depth_[num]" 빈 오브젝트 생성
  Ctrl+Shift+S : Image Component가 있는 오브젝트 생성
  Ctrl+Shift+L : TextMeshProFromUGUI가 있는 오브젝트 생성

 # Script
  자주 사용되는 스크립트를 일반화한 스크립트입니다.
  using YLibrary; 가 필요합니다.

# 일반화 클래스

## YSingleton

 Singleton Pattern을 일반화한 클래스입니다. YSingleton<ClassName>으로 상속받으시면 사용이 가능합니다.

 +ClassName instance : Singleton Class를 호출합니다.

## YLabel

 특정 변수를 캐스트해 Label로 보여주는 스크립트를 일반화한 클래스입니다. YLabel<Type>을 상속받으면 사용이 가능합니다.
 Update에서 작동하여도 부하가 적게 설계되었습니다.

 - Type : Label에 나타내고 싶은 변수의 타입
 + void SetText(Type t) : Label에 변수의 내용을 나타냅니다.

## YButton

 Button Component의 Interface를 구현해놓은 클래스입니다. YButton을 상속받으면 사용이 가능합니다.

 함수들을 overriding하여 사용이 가능합니다.

 + void OnButtonClickDown() : Button이 눌렸을 때
 + void OnButtonClickPressed() : Button을 누르고 있을 때
 + void OnButtonClickUp() : Button을 뗄 때

# 클래스

## YSound

Audio Clip을 재생시켜 줍니다.

+ void BackgroundRun(AudioClip clip) : 배경음악을 재생합니다. 이전에 재생하고 있었다면 교체합니다.
+ void SFXRun(AudioClip clip) : 효과음을 재생합니다. 제한업이 여러개 재생이 가능합니다.

## YEffect

Resources폴더의 Effect를 생성합니다. Effect는 YEffectTimer를 통해 생성 후 일정 시간뒤에 자동으로 파괴 되게 할 수 있습니다.

+ GameObject RunEffect(string path, float duration, Vector3 = new Vector3()) : 이펙트를 재생시킵니다.

## YObjectPool

 Object Pooling을 해주는 클래스입니다. 현재는 전역 단위로 되어 있지만 추후에 지역 단위로 변경할 예정입니다.

Pool안에 대상 GameObject가 없어도 가능합니다. 

 + void CreatePool(string name, GameObject dummy) : 새 Object Pool을 생성합니다.
 + void CreatePool(GameObject dummy) : GameObject의 이름인 Pool을 생성합니다.
 + void InPool(string name,  GameObject gameobject) : GameObject를 풀안에 넣습니다. GameObject의 확장메서드로도 구현되어 있습니다.
 + GameObject OutPool(string name) : Pool안에서 GameObject를 꺼냅니다.

## YResource

Resources.Load() 를 효과적으로 관리하기 위해 만들어진 클래스입니다. 로딩된 Object들을 캐싱되어 있습니다.

+ object Load(string path) : Resource path에서 Object를 로딩합니다.

## YCSVLoader
## YCoroutin

MonoBehaviour 상속받지 않는 객체도 Coroutin을 사용하기 위해 개발된 클래스입니다. YSingleton으로 구현되어  있습니다.

+ instance : Singleton Class를 호출합니다.
+ void StartCoroutin(UnityAction callback) : 코루틴 함수를 호출합니다.
+ void DelayMethod(float delay, UnityAction callback) : 일정 시간을 기다린 뒤 코루틴 함수를 호출합니다.

# 컴포넌트

## YAction

 간단한 함수 호출, GameObject Active 등 UI에 사용되는 Action들을 모아둔 컴포넌트 입니다.

![enter image description here](https://lh3.googleusercontent.com/WgfIBrwVnDWPzDKsioHtOZ9qpwUP4t-GBHQeYrB_4nAXmVqy10LGQhUo4i8awEgjmI5zKSs-Vgyz_5y5-gH3lBFdCZmjVK7WwkhUI15W1Zi0wpxjTEHlwNmyaiHSeQ9aVMNQlaVO2qwP4trXvrAnsojnsLztPkaTvlh0BCKAxyyCvN2mcXL9iUAeyzQzT9Nzm3-WrZib3a-fzBhf-yzcRPOVVG6nDXACJOTEKmf7gKd7fqDzmHaqfNvp-O0tb6CZY_0kNJlLxWPgw0TuY45R0hb9L3lGMRJxTbjJBuNofsdxplSx4KWm00wPslgPBZqNfP1h3-8s5XGNHq0uu-JjDQkW57IarlQzjkg-3fvK4g-YpgAQ0lvTZHcizfCn2SzQpRIlLjKyfswZ5hLq5KAnUrL2HCgV88he4TtKqa5DyA_XUym15DhrhXxfHr7jbVHTcufsTmzdKD_JDuJ4m8lVBMqo_Kt2OMyKqVFAgWjvWiAv1IBKIibUYQjtsNx6sqiDGn2ajijswuVSPB9dEbp9xJ2BiqwKoYGB110l2tdZRL7ckw6R3Cj7JsPyK3oA0Gmq5wUN3UatD9HtM91-0olz3Xy7nG8JKfMu15N4EjyYC-DUTYGKT-UkYoO3LAAwiNlXD9AoZSB17GKTjQ7BeYM9v0VCyQDvc9pqCxDl9q3fhM-ntFp6cD4FCQ=w457-h436-no)

Size : Action 갯수

	ActionName : 호출 될 Action의 이름
	Action Type : 실행할 Action의 종류
	
- ActiveObject
	- size : Object 갯수
	- Check Box : 변경할 Active 상태
	- GameObject : 대상 Object
- NextScene
	- Scene Name : 다음 씬
- Function
	- OnFunction : 실행한 Function

컴포넌트로 짜여진 Action들은 Action(string ActionName)으로 호출이 가능합니다.

## YAnimation

 간단한 Animation을 만들 수 있는 컴포넌트 입니다.

![enter image description here](https://lh3.googleusercontent.com/vfyOcFakBu4LmnO9a2VquH2qBYuPN2zsCzjfPRCd8Hx2PcH1c-uxj7IHiRZDR0ppyrJeL993ZpoINdr0AN78MsyaCuVbeNoJv0pxBz_cv7Dxc4clo6JfAc6bZdmiPpTaJsRmccACAHT5_6O9gXpta95yTAZoJ6iJcvkp0La3mMExxcLyjPyhKoaAJndGxks3bb3U8Gw_x_9XrW5mAs9Y759peegb4LcNYPZq-yCmhkfZjdgx0Qur-LP-5353OZnaQlpfw87aA4vG3uHDEZeE-F1GmZB-jK6wufU-UN8X9DfHj_-nepYBI8KoP8C-FgGrPhUPkpDh84waZPGpxciAk1iwS66sTjNV862xZxOH8KzhqEpJU9XBLks_JvGRjSHaZHnu7kV-VeL4mkXOO5Z0TdMYLsey9yzZBVOI4c8VFBBGb0GiU8TJ0WsZ4oSQNmL-GVbrOdSLG2ZmCmWCh9u91vz7c7LsOH99gaHs_HwMj4W-dPJ-AZDa5sKjAvpO2qjeScuXLYMU4EKyoemG4_Cd6SeFhccktNx2orIKxnLRraDUWfRtvQa_iNaMkzskjQXWeDafGvdB-vLtdka-2KUGceTvI84KBHmkzKSpl6d3lVRNDogPV6OakDE6JoKgU-OhDbfTbu2fTBdkHRgJ9ADP0vLeFsGhGHjfJOk4K8fIndmjCRLD-hE1Jg=w455-h332-no)

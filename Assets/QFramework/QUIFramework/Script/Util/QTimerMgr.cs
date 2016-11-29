using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Collections;

namespace QFramework {
	public interface ITimerBehaviour {
		void TimerUpdate();
	}
}

namespace QFramework {
    public class QTimerInfo {
        public long tick;
        public bool stop;
        public bool delete;
        public Object target;
        public string className;

        public QTimerInfo(string className, Object target) {
            this.className = className;
            this.target = target;
            delete = false;
        }
    }


	public class QTimerMgr : QMgrBehaviour {
		
		protected override void SetupMgrId ()
		{
			mMgrId = 0;
		}

		protected override void SetupMgr ()
		{
			
		}

		public static QTimerMgr Instance {
			get {
				return QMonoSingletonComponent<QTimerMgr>.Instance;
			}
		}

        private float interval = 0;
        private List<QTimerInfo> objects = new List<QTimerInfo>();

        public float Interval {
            get { return interval; }
            set { interval = value; }
        }

        // Use this for initialization
        void Start() {
			DontDestroyOnLoad (this);
            StartTimer(1.0f);
        }

        /// <summary>
        /// ������ʱ��
        /// </summary>
        /// <param name="interval"></param>
        public void StartTimer(float value) {
            interval = value;
            InvokeRepeating("Run", 0, interval);
        }

        /// <summary>
        /// ֹͣ��ʱ��
        /// </summary>
        public void StopTimer() {
            CancelInvoke("Run");
        }

        /// <summary>
        /// ��Ӽ�ʱ���¼�
        /// </summary>
        /// <param name="name"></param>
        /// <param name="o"></param>
        public void AddTimerEvent(QTimerInfo info) {
            if (!objects.Contains(info)) {
                objects.Add(info);
            }
        }

        /// <summary>
        /// ɾ����ʱ���¼�
        /// </summary>
        /// <param name="name"></param>
        public void RemoveTimerEvent(QTimerInfo info) {
            if (objects.Contains(info) && info != null) {
                info.delete = true;
            }
        }

        /// <summary>
        /// ֹͣ��ʱ���¼�
        /// </summary>
        /// <param name="info"></param>
        public void StopTimerEvent(QTimerInfo info) {
            if (objects.Contains(info) && info != null) {
                info.stop = true;
            }
        }

        /// <summary>
        /// ������ʱ���¼�
        /// </summary>
        /// <param name="info"></param>
        public void ResumeTimerEvent(QTimerInfo info) {
            if (objects.Contains(info) && info != null) {
                info.delete = false;
            }
        }

        /// <summary>
        /// ��ʱ������
        /// </summary>
        void Run() {
            if (objects.Count == 0) return;
            for (int i = 0; i < objects.Count; i++) {
                QTimerInfo o = objects[i];
                if (o.delete || o.stop) { continue; }
                ITimerBehaviour timer = o.target as ITimerBehaviour;
                timer.TimerUpdate();
                o.tick++;
            }
            /////////////////////////������Ϊɾ�����¼�///////////////////////////
            for (int i = objects.Count - 1; i >= 0; i--) {
                if (objects[i].delete) { objects.Remove(objects[i]); }
            }
        }
    }
}
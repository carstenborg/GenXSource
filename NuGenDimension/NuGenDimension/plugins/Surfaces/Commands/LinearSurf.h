#ifndef __LINEAR_SURFACE_Command__
#define __LINEAR_SURFACE_Command__

typedef struct  
{
	SG_POINT  pnt;
	double    coef;
} POINT_AND_HER_COEF;


#define COUNT_OF_POINTS_ON_CURVE_1    100
#define COUNT_OF_POINTS_ON_CURVE_2    4


typedef  enum
{
	NEED_OBJECT,
	NEED_ONE_OF_END_POINT,
	NEED_POINT_ON_CURVE,
	NEED_DIRECTION
} NEED_REGIME;

class LinearSurfaceCommand : public ICommander, public IContextMenuInterface
{
	IApplicationInterface* m_app;
private:
	IGetObjectsPanel*      m_get_object_panels[2];
	
	sgC2DObject*           m_objs[2];

	sgCObject*             m_cur_obj;

	std::vector<SG_POINT>  m_points_on_First;
	std::vector<SG_POINT>  m_points_on_Second;

	std::vector<POINT_AND_HER_COEF>  m_temp_buffer;

	bool                   m_inverse_second;
	double                 m_coef_on_second;

	int                    m_step;

	CString				   m_message;

	NEED_REGIME            m_need_regime;

	void                   NeedObject(int pX, int pY);
	void                   NeedOneOfEndPoint(int pX, int pY);
	void                   NeedPointOnCurve(int pX, int pY);
	void                   NeedDirection(int pX, int pY);

	bool                   m_inQuestionRegime;

public:
	LinearSurfaceCommand(IApplicationInterface* appI);
	virtual ~LinearSurfaceCommand();

	virtual void            Start()	;
	virtual bool            PreTranslateMessage(MSG* pMsg);
	virtual void            Draw();
	IContextMenuInterface*    GetContextMenuInterface() {return this;};

	virtual void            SendCommanderMessage(COMMANDER_MESSAGE, void*);

private:	
	virtual unsigned int    GetItemsCount();
	virtual void            GetItem(unsigned int, CString&);
	virtual void            GetItemState(unsigned int, bool&, bool&);
	virtual HBITMAP  GetItemBitmap(unsigned int);
	virtual void            Run(unsigned int);

	void            MouseMove(unsigned int,int,int);
	void            LeftClick(unsigned int,int,int);
	void            OnEnter();
};

#endif
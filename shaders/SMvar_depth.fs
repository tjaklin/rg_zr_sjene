#version 330 core

in vec4 mvpPos;

void main()
{
	float depth = mvpPos.z / mvpPos.w;
	depth = depth * 0.5 + 0.5;

	float moment1 = depth;

	float moment2 = depth * depth;

	float dx = dFdx(depth);
	float dy = dFdy(depth);

	moment2 += 0.25 * ( dx*dx + dy*dy );

	gl_FragColor = vec4( moment1, moment2, 0.0f, 0.0f );
}
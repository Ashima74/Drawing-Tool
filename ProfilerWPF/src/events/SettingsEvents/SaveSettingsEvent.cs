using Prism.Events;
using System;
using ProfilerCLR;
using System.Diagnostics;
using OpenTK.Mathematics;
using ProfilerWPF.src.events.RendererEvents;
using ProfilerWPF.rendering.renderer;
using System.Collections.Generic;
using ProfilerWPF.rendering.Shapes;
using System.IO;
using Microsoft.Win32;
using Prism.Services.Dialogs;

namespace ProfilerWPF.events.SettingsEvents
{
    class SaveSettingsEvent : PubSubEvent<bool>
    {

        private RsDataWrap _DxfHelper;
        private RsDataWrap _jobData;
        private List<Shape> dxfshapes;
        private string cfgFilePath;
        private string _DxfRSQ; // will use the Ifilepath generator

        private void Save_Click(object sender, EventArgs e)
        {
            //moving from renderer to rsdata
            WriteToDxfData(true);
            //moving shapes from rsdata to the rsq
            WritingDataDXFRSQ();
        }
        private void WriteToDxfData(bool flush)
        {

            if (flush)
            {
                _DxfHelper.deleteAllShapes();
            }

            //foreach shape in renderer.getShapes or something
            foreach (Shape shape in dxfshapes)
            {
                ArcPath path = (ArcPath)shape;
                _DxfHelper.addShape(ArcPathToAmcPath(path));
            }
        }
        private void WritingDataDXFRSQ()
        {
            int writeError = _jobData.writeDataWrap(cfgFilePath, _DxfRSQ, true);
            if (writeError != 0)
            {
                Debug.WriteLine($"Failed to write the new data to " + _DxfRSQ);
            }
            else
            {
                Debug.WriteLine($"Successfully wrote new data to " + _DxfRSQ);
            }
        }

        public static PathWrap ArcPathToAmcPath(ArcPath path)
        {
            // Debug helper.
            if (path.Count <= 0)
            {
                Console.WriteLine("Warning: Zero arcs fond in passed arcPath.");
            }

            PathWrap amcShapePath = new PathWrap();

            // Loop over all arcs in passed arcpath - convert and add them to the PathWrap.
            for (int i = 0; i < path.Count; i++)
            {
                // Forward arc property cache.
                Vector2 startpos = path.StartPosition(i);
                Vector2 endpos = path.EndPosition(i);
                Vector2 centerPos = path.CenterPosition(i);
                bool clockwise = path.Clockwise(i);
                float radius = path.Radius(i);

                // Straight arc.
                if (radius == 0.0f)
                {
                    amcShapePath.addVertex
                    (
                        // Straight segment - start point to end point.
                        new wcSegArcWrap(new wcPointWrap(startpos.X, startpos.Y), new wcPointWrap(endpos.X, endpos.Y)),
                        // Required because on the backend the endpos isn't always calculated or needed (depends on context of creation etc.), so bryan just makes sure it's always there.
                        new wcPointWrap(endpos.X, endpos.Y)
                    );
                }
                // Curved arc.
                else
                {
                    amcShapePath.addVertex
                    (
                        // Curved segment - start point to end point with center and if anticlockwise.
                        new wcSegArcWrap(new wcPointWrap(startpos.X, startpos.Y), new wcPointWrap(centerPos.X, centerPos.Y), !clockwise),
                        // Required because on the backend the endpos isn't always calculated or needed (depends on context of creation etc.), so bryan just makes sure it's always there.
                        new wcPointWrap(endpos.X, endpos.Y)
                    );
                }

                // If the arcpath isn't closed and we are processing the last arc. Here we must add a 'ghost' arc at the final endpoint
                // This is due to the case on the backend where the endpoints arent calculated and only known by looking at arc[i+1].startPos in the path
                // e.g. if there is a single arc, and bryan tries to check the endpoint of it, arc[i+1].startPos would be null, so we need to add another
                // arc that is just a point on the endpoint so arc[i+1].startPos will return the correct value
                if (!path.Closed && i == (path.Count - 1))
                {
                    amcShapePath.addVertex
                    (
                        // End point to end point - signify end of open arc path.
                        new wcSegArcWrap(new wcPointWrap(endpos.X, endpos.Y), new wcPointWrap(endpos.X, endpos.Y)),
                        // Required because on the backend the endpos isn't always calculated or needed (depends on context of creation etc.), so bryan just makes sure it's always there.
                        new wcPointWrap(endpos.X, endpos.Y)
                    );
                }
            }

            amcShapePath.setClosed(path.Closed);

            // Group three is set to a router tool in the current rsq used for demo.
            amcShapePath.setGroup(3);

            return amcShapePath;
        }
    }
}

<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:no="http://genetibase.com/Schemas/OCIDML.xsd">
  <xsl:output method="text" omit-xml-declaration="yes"/>
<xsl:template match="/no:Diagram/no:ModelSystem">
// Generated by NuGenObjective for Visual Studio 2005

<xsl:for-each select="./no:Objects/no:ModelObject">
public class <xsl:value-of select="translate(no:Name,' ','_')"/> {
<xsl:for-each select="./no:Interactions/no:Interaction">
    public void <xsl:value-of select="translate(no:Name,' ', '_')"/>() {
        // Role check here, like this:
        // if(IsInRole(&quot;<xsl:value-of select="translate(no:RoleRef,' ','_')"/>&quot;)) {
        //     // Perform action
        //     <xsl:value-of select="translate(no:ActionRef,' ','_')"/>();
        // }
    }
</xsl:for-each>
}
</xsl:for-each>
</xsl:template>

  <xsl:template match="/">
    <xsl:apply-templates select="/no:Diagram/no:ModelSystem" />
  </xsl:template>
</xsl:stylesheet>